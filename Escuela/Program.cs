using System;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Alumno alumno = new Alumno(1, "Juanes", 034555);
            Console.WriteLine(alumno.Codigo + " " + alumno.Nombre + " " + alumno.Carnet);
        }
    }
}
