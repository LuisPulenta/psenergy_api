using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class ControlPozoValoresFormula
    {
        [Key]
        public int IDCONTROLFORMULA { get; set; }
        public int? IDCONTROLCAB { get; set; }
        public string IDPOZO { get; set; }
        public int? IDFORMULA { get; set; }
        public decimal? VALOR { get; set; }
        public DateTime? FechaAPP { get; set; }
    }
}
