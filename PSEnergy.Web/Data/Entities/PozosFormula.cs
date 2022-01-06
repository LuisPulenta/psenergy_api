using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class PozosFormula
    {
        [Key]
        public int IDFORMULA { get; set; }
        public string TIPOSISTEMA { get; set; }
        public string TIPODATOS { get; set; }
        public int RANGODESDE { get; set; }
        public int RANGOHASTA { get; set; }
    }
}