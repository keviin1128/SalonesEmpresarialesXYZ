using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Salones_empresariales_xyz.Models;
using Salones_empresariales_xyz.Models.ViewModels;

namespace Salones_empresariales_xyz.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ListClienteViewModel> lst;
            using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
            {
                lst = (from d in bd.CLIENTE
                           select new ListClienteViewModel
                           {
                               Id = d.ID,
                               Identificacion = d.IDENTIFICACION,
                               NombreCompleto = d.NOMBRE,
                               Telefono = d.TELEFONO,
                               Correo = d.CORREO,
                               Departamento = d.DEPARTAMENTO,
                               Ciudad = d.CIUDAD,
                               Edad = d.EDAD,
                           }).ToList();
            } 
            return View(lst);
        }

        public ActionResult Nuevo()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
                    {
                        var objCliente = new CLIENTE();
                        objCliente.IDENTIFICACION = model.Identificacion;
                        objCliente.NOMBRE = model.NombreCompleto;
                        objCliente.TELEFONO = model.Telefono;
                        objCliente.CORREO = model.Correo;
                        objCliente.DEPARTAMENTO = model.Departamento;
                        objCliente.CIUDAD = model.Ciudad;
                        objCliente.EDAD = model.Edad;

                        bd.CLIENTE.Add(objCliente);
                        bd.SaveChanges();
                    }
                    return Redirect("~/Cliente/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Editar(int Id)
        {
            ClienteViewModel model = new ClienteViewModel();
            using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities()) 
            {
                var oCliente = bd.CLIENTE.Find(Id);
                model.Identificacion = oCliente.IDENTIFICACION;
                model.NombreCompleto = oCliente.NOMBRE;
                model.Telefono = oCliente.TELEFONO;
                model.Correo = oCliente.CORREO;
                model.Ciudad = oCliente.CIUDAD;
                model.Departamento = oCliente.DEPARTAMENTO;
                model.Edad = oCliente.EDAD;
                model.Id = oCliente.ID;
            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Editar(ClienteViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SALONES_EMPRESARIALES_XYZEntities bd = new SALONES_EMPRESARIALES_XYZEntities())
                    {
                        var objCliente = bd.CLIENTE.Find(model.Id);
                        objCliente.IDENTIFICACION = model.Identificacion;
                        objCliente.NOMBRE = model.NombreCompleto;
                        objCliente.TELEFONO = model.Telefono;
                        objCliente.CORREO = model.Correo;
                        objCliente.DEPARTAMENTO = model.Departamento;
                        objCliente.CIUDAD = model.Ciudad;
                        objCliente.EDAD = model.Edad;

                        bd.Entry(objCliente).State = System.Data.Entity.EntityState.Modified;
                        bd.SaveChanges();
                    }
                    return Redirect("~/Cliente/");
                }
                return View(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}