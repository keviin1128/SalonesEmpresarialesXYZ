using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Salones_empresariales_xyz.Models.ViewModels
{
    public class ListClienteViewModel
    {
        public int Id{ get; set; }
        public string Identificacion { get; set; }
        public string NombreCompleto{ get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Edad { get; set; }
    }
}