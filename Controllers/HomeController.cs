using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaPersona.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            {
                var persona = new List<Models.Persona>
                {


            new Models.Persona_{ Sexo = "Mujer", Nombres = "Juana", Apellido = "Perez", Telefono = "82956454", Direccion = "Barrio enriquillo", Cedula = "019482773"},
              new Models.Persona_{ Sexo = "Hombre", Nombres = "Juan", Apellido = "Feliz", Telefono = "829756454", Direccion = "Barrio Parmarito", Cedula = "019482633"},
                new Models.Persona_{ Sexo = "Nombre", Nombres = "Antonio", Apellido = "Perez", Telefono = "829543243", Direccion = "Por ahi..", Cedula = "0194324233"},
                  new Models.Persona_{ Sexo = "Mujer", Nombres = "Miguelina", Apellido = "Morales", Telefono = "829563434", Direccion = "Villa Estela", Cedula = "0194826453"},

            };

                return View(persona);
            }
        }
    }
}

    
