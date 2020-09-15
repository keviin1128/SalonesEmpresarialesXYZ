using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Salones_empresariales_xyz.Models;
using Salones_empresariales_xyz.Models.ViewModels;

namespace Salones_empresariales_xyz.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Index()
        {
            List<ListEventoViewModel> lst;
            using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
            {
                lst = (from d in bd.EVENTO
                       select new ListEventoViewModel
                       {
                           Id = d.ID,
                           Fecha = d.FECHA,
                           CantidadPersonas = d.CANTIDAD_PERSONAS,
                           Motivo = d.MOTIVO,
                           Observaciones = d.MOTIVO,
                           Estado = d.ESTADO,
                           ClienteId = d.CLIENTE.NOMBRE,

                       }).ToList();
            }
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(EventoViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
                    {
                        var objEvento = new EVENTO();
                        objEvento.FECHA = model.Fecha;
                        objEvento.CANTIDAD_PERSONAS = model.CantidadPersonas;
                        objEvento.MOTIVO = model.Motivo;
                        objEvento.OBSERVACIONES = model.Observaciones;
                        objEvento.ESTADO = model.Estado;
                        objEvento.CLIENTE_ID = model.ClienteId;

                        bd.EVENTO.Add(objEvento);
                        bd.SaveChanges();
                    }
                    return Redirect("~/Evento/");
                }
                return View(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
            {
                var oEvento = bd.EVENTO.Find(Id);
                bd.EVENTO.Remove(oEvento);
                bd.SaveChanges();
            }
            return Redirect("~/Evento/");
        }
    }
}