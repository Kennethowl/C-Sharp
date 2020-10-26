using System;

namespace Escuela
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno();
            alumno1.Codigo = 1;

            Alumno alumno2 = new Alumno(222222);
            alumno2.Codigo = 222222;

            Alumno alumno3 = new Alumno(1, "Juanes", 034555);

            Lista  alumno4 = new Lista("Alejandra", "Arauz");
            Lista  alumna5 = new Lista("Maholy", "Broonfield");

            alumno4.inactivarAlumno();

            Console.WriteLine(alumno1.Codigo);
            Console.WriteLine(alumno2.Codigo);
            Console.WriteLine(alumno3.Codigo + " " + alumno3.Nombre + " " + alumno3.Carnet);
            Console.WriteLine(alumno4.nombreCompleto());
            Console.WriteLine(alumna5.nombreCompleto());

            alumno4.activarAlumno();

            Console.WriteLine("");
            Console.WriteLine(alumno4.nombreCompleto());
            Console.WriteLine(alumna5.nombreCompleto());

        }
    }
}
