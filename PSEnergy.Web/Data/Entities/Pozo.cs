using System;
using System.ComponentModel.DataAnnotations;
namespace PSEnergy.Web.Data.Entities
{
    public class Pozo
    {
        [Key]
        public string CODIGOPOZO { get; set; }
        public string CODIGOBATERIA { get; set; }
        public string DESCRIPCION { get; set; }
        public DateTime FECHAALTA { get; set; }
        public int ACTIVO { get; set; }
        public DateTime ULTIMALECTURA { get; set; }
        public string LATITUD { get; set; }
        public string LONGITUD { get; set; }
        public string QRCODE { get; set; }
        public string OBSERVACIONES { get; set; }
        public string TIPOPOZO { get; set; }
        public string SistemaExtraccion { get; set; }
        public string Cuenca { get; set; }
        public int IDProvincia { get; set; }
        public decimal Cota { get; set; }
        public decimal Profundidad { get; set; }
        public decimal VidaUtil { get; set; }

    }
}
