using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04progGordonCukier.Models;

namespace TP04progGordonCukier.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

 
        public IActionResult Index()
        {
            return View(); 
        }

        public IActionResult NuevaPartida()
        {
            Juego.IniciarNuevaPartida();
            return View("Jugar");
        }

        public IActionResult Jugar()
        {
            if (Juego.JuegoTerminado)

            return View(Juego.ObtenerEstado());
        }

        [HttpPost]
        public IActionResult EnviarLetra(char letra)
        {
            Juego.IntentarLetra(letra);
            return RedirectToAction("Jugar");
        }

        [HttpPost]
        public IActionResult EnviarPalabra(string palabra)
        {
            Juego.IntentarPalabra(palabra);
            return RedirectToAction("Jugar");
        }

      
}