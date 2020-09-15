using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Salones_empresariales_xyz.Models.ViewModels
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Identificación")]
        public string Identificacion { get; set; }
        [Required]
        [Display(Name = "Nombre completo")]
        public string NombreCompleto { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Correo electrónico")]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }
        [Required]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        [Required]
        [Display(Name = "Edad")]
        public string Edad { get; set; }
    }

}