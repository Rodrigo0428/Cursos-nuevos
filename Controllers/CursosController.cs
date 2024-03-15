using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Cursos_nuevos.Models;

namespace Cursos_nuevos.Controllers
{
    public class CursoController : Controller
    {
        private readonly ILogger<CursoController> _logger;

        public CursoController(ILogger<CursoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cursos curso) // Assuming your model class name is Curso
        {
            if (ModelState.IsValid)
            {
                // Implement logic to save the Curso object to your data store (database, file, etc.)
                // Example (replace with your actual saving logic):
                // _context.Cursos.Add(curso);
                // _context.SaveChanges();

                ViewData["Message"] = "El curso se ha creado exitosamente.";

                // Add logic for specific course (e.g., "Programación Web") and discount
                if (curso.Nombre != null && curso.Nombre.Equals("Programación Web"))
                {
                    ViewData["Message"] = "El curso de Programación Web tiene un descuento especial.";
                }

                return View("Index");
            }

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
