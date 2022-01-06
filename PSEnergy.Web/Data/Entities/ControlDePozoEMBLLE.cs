using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class ControlDePozoEMBLLE
    {
        [Key]
        public int IdControlPozo { get; set; }
        public string Bateria { get; set; }
        public string Pozo { get; set; }
        public DateTime? Fecha { get; set; }
        public decimal? Ql { get; set; }
        public decimal? Qo { get; set; }
        public decimal? Qw { get; set; }
        public decimal? Qg { get; set; }
        public decimal? WCLibre { get; set; }
        public decimal? WCEmulc { get; set; }
        public decimal? WCTotal { get; set; }
        public decimal? Sales { get; set; }
        public decimal? GOR { get; set; }
        public decimal? T { get; set; }
        public string ValidacionControl { get; set; }
        public decimal? PrTbg { get; set; }
        public decimal? PrLinea { get; set; }
        public decimal? PrCsg { get; set; }
        public decimal? RegimenOperacion { get; set; }
        public decimal? AIBCarrera { get; set; }
        public decimal? BESPIP { get; set; }
        public decimal? PCPTorque { get; set; }
        public string OBSERVACIONES { get; set; }
        public int? ValidadoSupervisor { get; set; }
        public int? UserIdInput { get; set; }
        public int? UserIDValida { get; set; }
        public decimal? CaudalInstantaneo { get; set; }
        public decimal? CaudalMedio { get; set; }
        public decimal? LecturaAcumulada { get; set; }
        public decimal? PresionBDP { get; set; }
        public decimal? PresionAntFiltro { get; set; }
        public decimal? PresionEC { get; set; }
        public string IngresoDatos { get; set; }
        public int? Reenvio { get; set; }
        public string Muestra { get; set; }
        public DateTime? FechaCarga { get; set; }
        public int? IDUserValidaMuestra { get; set; }
        public int? IdUserImputSoft { get; set; }
        public decimal? Volt { get; set; }
        public decimal? Amper { get; set; }
        public decimal? Temp { get; set; }
        public DateTime? FechaCargaAPP { get; set; }

    }
}
