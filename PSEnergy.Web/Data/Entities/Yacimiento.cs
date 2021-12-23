using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class Yacimiento
    {
        [Key]
        public string NOMBREYACIMIENTO { get; set; }
        public DateTime FECHAALTA { get; set; }
        public string AREA { get; set; }
        public int ACTIVO { get; set; }
    }
}
