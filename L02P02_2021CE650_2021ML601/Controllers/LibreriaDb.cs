using AspNetCore;
using L02P02_2021CE650_2021ML601.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021CE650_2021ML601.Controllers
{
    public class LibreriaDb : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Crear()
        {
            return View();
        }

        // POST: /Libros/Crear
        [HttpPost]
        public ActionResult Crear(LibreriaDb libro)
        {
            if (ModelState.IsValid)
            {
                // Aquí puedes guardar el libro en la base de datos
                // Por ejemplo, utilizando Entity Framework
                //dbContext.Libros.Add(libro);
                //dbContext.SaveChanges();

                TempData["Mensaje"] = "Libro guardado correctamente";
                return RedirectToAction("Index", "Home");
            }

            return View(libro);
        }
    }
} 
