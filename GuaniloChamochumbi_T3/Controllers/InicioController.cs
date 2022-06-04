using GuaniloChamochumbi_T3.DB;
using GuaniloChamochumbi_T3.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.Controllers
{
    public class InicioController : Controller
    {
        private AppregistroContext context;
        public InicioController(AppregistroContext context)
        {
            this.context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var mascota = context.Registros.ToList();
            return View(mascota);
        }
        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.sexo = context.sexos.ToList();
            ViewBag.raza = context.razas.ToList();
            ViewBag.especie = context.especies.ToList();

            var regi = context.Registros.ToList();
            return View(regi);
        }
        [HttpPost]
        public IActionResult Create(registro registro)
        {
            if (ModelState.IsValid)
            {
                context.Registros.Add(registro);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();

        }
        private Usuario getlooged()
        {
            var claims = HttpContext.User.Claims.First();
            string username = claims.Value;
            var user = context.Usuarios.First(o => o.Username == username);
            return user;
        }
    }
}
