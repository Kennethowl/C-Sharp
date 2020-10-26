using System;
using System.Collections.Generic;

namespace ForeachyList
{
    class Program
    {
        static void Main(string[] args)
        {
         List<string> nombres = new List<string>();
         nombres.Add("Pedro");
         nombres.Add("Thomas");
         nombres.Add("Marcos");

         foreach (var nombre in nombres)
         {
            console.writeline(nombre);
         }

         List<int> numeros = new List<int>();
         numeros.Add(1);
         numeros.Add(2);
         numeros.Add(3);

          foreach (var n in numeros)
         {
            console.writeline(n);
         }

         List<Alumno> alumnos = new List<Alumno>();
         Alumno a = new Alumno(001, "Marcus");
         Alumno b = new Alumno(002, "Martha");
         Alumno c = new Alumno(003, "Mayra");
         Alumno d = new Alumno(004, "Greydi");
          
         alumnos.Add(a);
         alumnos.Add(b);
         alumnos.Add(c);
         alumnos.Add(d);
         
         foreach (var alumno in alumnos)
            {
             console.writeline(alumno.ID, alumno.Nombre);
            }
        }
    }  
}