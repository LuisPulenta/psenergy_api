using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergyApi.Web.Data.Entities
{
    public class Usuario
    {
        [Key]
        public int IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Login { get; set; }
        public string Contrasena { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        [Display(Name = "Usuario")]
        public string FullName => $"{Nombre} {Apellido}";
    }
}