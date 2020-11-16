using System;

public class Nota
{
    public double Primer { get; set; }
    public double Segundo { get; set; }
    public double Tercer { get; set; }

    public Nota(double primer, double segundo, double tercer)
    {
        Primer = primer;
        Segundo = segundo;
        Tercer = tercer;

    }  
}


namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NotasFinales notasfinales = new NotasFinales();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Notas Finales II Periodo");
                Console.WriteLine("========================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Estudiantes");
                Console.WriteLine("2 - Lista de Clases");
                Console.WriteLine("3 - Notas por parcial");
                Console.WriteLine("4 - Notas Finales");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        notasfinales.listaEstudiantes();
                        break;
                    case "2":
                        notasfinales.listaClases();
                        break;
                    case "3":
                        
                        break;
                    case "4":
                       
                        break;      
                    case "5":
                       
                        break;                                          
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
