using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using Salones_empresariales_xyz.Models;
using Salones_empresariales_xyz.Models.ViewModels;

namespace Salones_empresariales_xyz.Controllers
{
    public class EventoConfirmadoController : Controller
    {
        // GET: EventoConfirmado
        public ActionResult Index()
        {
            List<ListEventosConfirmadosViewModel> lst;
            using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
            {

                lst = (from d in bd.EVENTO
                       select new ListEventosConfirmadosViewModel
                       {
                           NombreCompleto = d.CLIENTE.NOMBRE,
                           Identificacion = d.CLIENTE.IDENTIFICACION,
                           Telefono = d.CLIENTE.TELEFONO,
                           Ciudad = d.CLIENTE.CIUDAD,
                           Fecha = d.FECHA,
                           CantidadPersonas = d.CANTIDAD_PERSONAS,
                           Motivo = d.MOTIVO,
                           Estado = d.ESTADO,
                       }).ToList();

            }
            return View(lst);
        }
    }
}