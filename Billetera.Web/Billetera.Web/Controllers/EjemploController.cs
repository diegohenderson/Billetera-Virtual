using Billetera.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Billetera.Web.Controllers
{
    public class EjemploController : Controller
    {
        // GET: Personas
        public ActionResult Index()
        {
            GestorEjemplo gestorPersonas = new GestorEjemplo();
            List<Ejemplo> lista = gestorPersonas.ObtenerPersonas();
            return View(lista);
        }
        public ActionResult Eliminar(int Id)
        {
            GestorEjemplo gestorPersonas = new GestorEjemplo();
            gestorPersonas.Eliminar(Id);

            List<Ejemplo> lista = gestorPersonas.ObtenerPersonas();
            return View("Index", "", lista);
        }
        [HttpGet]
        public ActionResult Agregar()
        {
            Ejemplo p = new Ejemplo();
            return View(p);
        }
        [HttpPost]
        public ActionResult Agregar(Ejemplo p)
        {
            GestorEjemplo gestorPersonas = new GestorEjemplo();
            gestorPersonas.AgregarPersona(p);
            List<Ejemplo> lista = gestorPersonas.ObtenerPersonas();
            return View("Index", "", lista);
        }


        [HttpGet]
        public ActionResult Modificar(int id)
        {
            GestorEjemplo gestorPersonas = new GestorEjemplo();
            Ejemplo p = gestorPersonas.ObtenerPorId(id);
            return View(p);
        }
        [HttpPost]
        public ActionResult Modificar(Ejemplo p)
        {
            GestorEjemplo gestorPersonas = new GestorEjemplo();
            gestorPersonas.ModificarPersona(p);
            List<Ejemplo> lista = gestorPersonas.ObtenerPersonas();
            return View("Index", "", lista);
        }

    }
}