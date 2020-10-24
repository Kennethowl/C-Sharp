using System;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Codigo = 1;
            alumno1.Nombre = "Kenneth";
            alumno1.Carnet = 2222222;

            Console.WriteLine (alumno1.Codigo + " " + alumno1.Nombre + " " + alumno1.Carnet);
            
            
                
            
        }
    }
}
