using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Examen1_GestorPaquetes.BL;
using Examen1_GestorPaquetes.DA;
using Examen1_GestorPaquetes.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen1_GestorPaquetes.UI.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IRepositorioDePaquetes Repositorio;

        public PersonaController(IRepositorioDePaquetes repositorio)
        {
            Repositorio = repositorio;
        }

        // GET: PersonaController
        public ActionResult Listar()
        {
            List<Persona> personal;

            personal = Repositorio.ObtenerTodasLasPersonas();

            return View(personal);
        }



        // GET: PersonaController/Create
        public ActionResult Crear2()
        {
            return View();
        }

        // POST: PersonaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear2(PersonaConFoto persona)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repositorio.AgregarPersona(persona);

                    return RedirectToAction(nameof(Listar));

                }
                else { return View(); }
            }
            catch
            {
                return View();
            }
        }


    }
}
