using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class Bateria
    {
        [Key]
        public string CODIGOBATERIA { get; set; }
        public string DESCRIPCION { get; set; }
        public DateTime? FECHAALTA { get; set; }
        public int ACTIVA { get; set; }
        public string NOMBREYACIMIENTO { get; set; }
    }
}
