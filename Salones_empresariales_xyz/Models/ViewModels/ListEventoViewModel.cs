using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salones_empresariales_xyz.Models.ViewModels
{
    public class ListEventoViewModel
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string CantidadPersonas { get; set; }
        public string Motivo { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
        public string ClienteId { get; set; }
    }
}