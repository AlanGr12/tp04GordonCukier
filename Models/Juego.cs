using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04progGordonCukier.Models;

namespace TP04progGordonCukier{

public static class Juego
{

    public static string palabraOriginal {get; private set; }
    public static string palabraParcial {get; private set; }
    private static string[] listaPalabras = {"computadora", "internet", "programacion"};

    public static int Intentos {get; private set;}
    public static List<char> LetrasUsadas{get; private set;}

    public static bool juegoTerminado{get; private set;}

    public static bool gano{get;private set;}

    public static void reiniciar(){
        var random = new Random();

        palabraOriginal = listaPalabras[random.Next(listaPalabras.Length)];
        palabraParcial = "";

        for(int i = 0; i < palabraOriginal.Length; i++){{
            palabraParcial += "-";
        }
        Intentos = 0;
        LetrasUsadas = new List<char>();
        juegoTerminado = false;
        gano = false;

        
    
        }
    }

    
    public static void arriesgarLetra(char letra){

      
        
        if(!LetrasUsadas.Contains(letra))
        {

        LetrasUsadas.Add(letra);

        string nuevaParcial = "";

        bool acierto = false;

        for(int i = 0; i< palabraOriginal.Length; i++){
            if(palabraOriginal[i] == letra){    
                nuevaParcial += letra;
                acierto = true;
            }

            else{
                nuevaParcial += palabraParcial[i];
            }
        }

        palabraParcial = nuevaParcial;


        if(palabraParcial == palabraOriginal){
            juegoTerminado = true;
            gano = true;
        }


        Intentos++;
        
        }
    }

         public static void arriesgarPalabra(string intento)
        {
            Intentos++;

            if(intento == palabraOriginal){
            
            palabraParcial = palabraOriginal;
            juegoTerminado = true;
            gano = true;

            }

        }

    }
}


    


