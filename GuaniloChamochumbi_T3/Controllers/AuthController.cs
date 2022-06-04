using GuaniloChamochumbi_T3.DB;
using GuaniloChamochumbi_T3.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.Controllers
{
    public class AuthController : Controller
    {
        private AppregistroContext context;
        private IConfiguration configuration;
        public AuthController(AppregistroContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = context.Usuarios
               .FirstOrDefault(o => o.Username == username && o.Password == CreateHash(password));
            //  var user = context.Usuarios.FirstOrDefault(o => o.Username == usernme && o.Password == CreateHash(password));
            if (user == null)
            {
                TempData["AuthMessaje"] = "Usuario o password incorrectos";
                return RedirectToAction("Login");
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Username),

                };
                //session[];

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                HttpContext.SignInAsync(claimsPrincipal);
               return RedirectToAction("Index", "Inicio");

            }

            return View();

        }
        [HttpGet]
        public IActionResult Logaut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Create()
        {
            var user = context.Usuarios.ToList();
            return View(user);
            //return CreateHash(password);
        }
        [HttpPost]
        public IActionResult Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Password = CreateHash(usuario.Password);
                context.Usuarios.Add(usuario);
                context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        private string CreateHash(string input)
        {
            input += configuration.GetValue<string>("Key");
            var sha = SHA512.Create();
            var bytes = Encoding.Default.GetBytes(input);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
