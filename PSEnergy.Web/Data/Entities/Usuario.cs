using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class Usuario
    {
        [Key]
        public int IDUser { get; set; }
        public string CODIGO { get; set; }
        public string APELLIDONOMBRE { get; set; }
        public string USRLOGIN { get; set; }
        public string USRCONTRASENA { get; set; }
        public int PERFIL { get; set; }
        public int HabilitadoWeb { get; set; }
        public string CausanteC { get; set; }
        public int HabilitaPaqueteria { get; set; }
    }
}
