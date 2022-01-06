using System.ComponentModel.DataAnnotations;
namespace PSEnergy.Web.Data.Entities
{
    public class PozosControle
    {
        [Key]
        public int IDCONTROL { get; set; }
        public string CODIGOPOZO { get; set; }
        public int IDFORMULA { get; set; }
        public string ALARMA { get; set; }
        public string Obligatorio { get; set; }
    }
}
