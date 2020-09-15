using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Salones_empresariales_xyz.Models.ViewModels
{
    public class EventoViewModel
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha del evento")]
        public DateTime Fecha { get; set; }
        [Required]
        [Display(Name = "Cantidad de asistentes")]
        public string CantidadPersonas { get; set; }
        [Required]
        [Display(Name = "Motivo del evento")]
        public string Motivo { get; set; }
        [Required]
        [Display(Name = "Observaciones")]
        public string Observaciones { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Required]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }
    }
}