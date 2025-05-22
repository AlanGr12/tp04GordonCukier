using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04progGordonCukier.Models;

namespace TP04progGordonCukier.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

 

    public IActionResult Inicio()
    {
        Juego.reiniciar(); 
        return View("Inicio");
    }



    [HttpGet]




    public IActionResult jugar(){
        if(Juego.juegoTerminado){
            return View("Resultado");
        }
        ViewBag.PalabraParcial = Juego.palabraParcial;
        ViewBag.Intentos = Juego.Intentos;
        ViewBag.LetrasUsadas = Juego.LetrasUsadas;

        return View("Jugar");
    }

    [HttpPost]

    

    public IActionResult arriesgarLetra(char letra){

               if (letra != '\0')
        {
            Juego.arriesgarLetra(letra);
        }

        return View();
    }


    [HttpPost]


    public IActionResult arriesgarPalabra(string palabra){
        if(palabra != null){
            Juego.arriesgarPalabra(palabra);
        }

        return View();
    }

    public IActionResult Resultado(){
     ViewBag.gano = Juego.gano;
    return View("Resultado");
    }}

    
