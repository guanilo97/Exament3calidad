﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = ("Username es obligatorio"))]
        public string Username { get; set; }
        [Required(ErrorMessage = ("Password es obligatorio"))]
        public string Password { get; set; }
    }
}
