using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salones_empresariales_xyz.Models.ViewModels
{
    public class ListEventosConfirmadosViewModel
    {
        public string NombreCompleto { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public DateTime Fecha { get; set; }
        public string CantidadPersonas { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }

    }
}