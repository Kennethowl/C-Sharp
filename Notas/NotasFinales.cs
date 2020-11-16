using System;
using System.Collections.Generic;

public class NotasFinales
{
    public List<Estudiante> ListaEstudiantado { get; set; }
    public List<Clases> ListadodeClases { get; set; }

    public NotasFinales()
    {
        ListaEstudiantado = new List<Estudiante>();
        cargarestudiantes();
        ListadodeClases = new List<Clases>();
        cargarclases();

    }
    
    public void cargarestudiantes(){
        Estudiante n1 = new Estudiante("1", 123, "Kenneth", "Flores", "Hombre");
        ListaEstudiantado.Add(n1);
        Estudiante n2 = new Estudiante("2", 123, "Mayra", "Arauz", "Mujer");
        ListaEstudiantado.Add(n2);
        Estudiante n3 = new Estudiante("3", 123, "Karina", "Sierra", "Mujer");
        ListaEstudiantado.Add(n3);
        Estudiante n4 = new Estudiante("4", 123, "Sergi", "Flores", "Hombre");
        ListaEstudiantado.Add(n4);
        Estudiante n5 = new Estudiante("5", 123, "Juan", "Calix", "Hombre");
        ListaEstudiantado.Add(n5);
        Estudiante n6 = new Estudiante("6", 123, "Molly", "Herrera", "Mujer");
        ListaEstudiantado.Add(n6);
        Estudiante n7 = new Estudiante("7", 123, "Thania", "Benitez", "Mujer");
        ListaEstudiantado.Add(n7);
        Estudiante n8 = new Estudiante("8", 123, "Greydi", "Avila", "Mujer");
        ListaEstudiantado.Add(n8);
        Estudiante n9 = new Estudiante("9", 123, "Alexis", "Benitez", "Hombre");
        ListaEstudiantado.Add(n9);
        Estudiante n10 = new Estudiante("10", 123, "Daniel", "Brizuela", "Hombre");
        ListaEstudiantado.Add(n10);
       
    }

    public void cargarclases(){
        Clases c1 = new Clases("1", "Lenguaje de Programacion II");
        ListadodeClases.Add(c1);
        Clases c2 = new Clases("2", "Sistemas Operativos II");
        ListadodeClases.Add(c2);
        Clases c3 = new Clases("3", "Taller de Hardware II");
        ListadodeClases.Add(c3);
        Clases c4 = new Clases("4", "Base de Datos I");
        ListadodeClases.Add(c4);
        Clases c5 = new Clases("5", "Redes Informaticas");
        ListadodeClases.Add(c5);
    }

    public void listaEstudiantes(){
        Console.Clear();
        Console.WriteLine("Listado de Estudiantes");
        Console.WriteLine("**********************");
        Console.WriteLine("| Codigo | Carnet | Nombre | Apellido | Sexo |");
        Console.WriteLine("");
         
         foreach (var alumno in ListaEstudiantado)
        {
            Console.WriteLine(alumno.Codigo + " | " + alumno.Carnet  + " | " + alumno.Nombre + " | " + alumno.Apellido + " | " + alumno.Sexo);
        }

        Console.ReadLine();
    }

    public void listaClases(){
         Console.Clear();
        Console.WriteLine("   Listado de Clases  ");
        Console.WriteLine("**********************");
        Console.WriteLine("| Codigo | Clase |");
        Console.WriteLine("");
         
         foreach (var clase in ListadodeClases)
        {
            Console.WriteLine(clase.Code + " | " + clase.Clase);
        }

        Console.ReadLine();
    }


    
}