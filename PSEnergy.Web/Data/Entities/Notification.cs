using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class Notification
    {
        [Key]
        public int IDNOTFICACION { get; set; }
        public string TIPO { get; set; }
        public DateTime? FECHACARGA { get; set; }
        public DateTime? FECHAEMREC { get; set; }
        public string EMISOR { get; set; }
        public string ENTEEMPRESA { get; set; }
        public string JURIDICCION { get; set; }
        public string AREA { get; set; }
        public string NOTAREFERENCIA { get; set; }
        public int? PLAZO { get; set; }
        public string Dirigidoa { get; set; }

        public string Clase { get; set; }
        public string NroExpediente { get; set; }
        public string Estado { get; set; }
        public string Prioridad { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
