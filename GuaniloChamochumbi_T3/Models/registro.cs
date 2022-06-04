using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuaniloChamochumbi_T3.Models
{
    public class registro
    {
        public int Id{ get; set; }
        [Required(ErrorMessage = ("codigo es obligatorio"))]
        public string Codigo_Registro { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public DateTime Fecha_registro { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string Nombre_mascota { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public DateTime Fecha_nacimiento { get; set; }
        public int Id_sexo { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public int Id_raza { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public int Id_especie { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string Tamaño { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string Datos_particulares { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string Direccion { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string Nombre_dueño { get; set; }
        [Required(ErrorMessage = ("campo obligatorio"))]
        public string telefono { get; set; }
        [EmailAddress(ErrorMessage = ("Formato de correo invalido"))]
        public string Email { get; set; }
        public Raza raza { get; set; }
        public Sexo sexo { get; set; }
        public Especie especie { get; set; }
        
    }
}
