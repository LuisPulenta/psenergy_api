using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class ControlDePozoAlarma
    {
        [Key]
        public int IDALARMA { get; set; }
        public DateTime? FECHACARGA { get; set; }
        public int PROVIENEIDCONTROL { get; set; }
        public string POZO { get; set; }
        public string BATERIA { get; set; }
        public int? IDUSUARIOCARGA { get; set; }
        public int? IDUSUARIOAPP { get; set; }
        public DateTime? FECHAEJECUTADA { get; set; }
        public int? NUEVOIDCONTROL { get; set; }
        public string OBSERVACION { get; set; }
        public int? TAG { get; set; }
    }
}
