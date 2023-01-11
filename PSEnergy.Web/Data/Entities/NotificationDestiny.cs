using System;
using System.ComponentModel.DataAnnotations;

namespace PSEnergy.Web.Data.Entities
{
    public class NotificationDestiny
    {
        [Key]
        public int IDNOTIFICACION { get; set; }
        public int IDUSER { get; set; }
        public string Observaciones { get; set; }
    }
}
