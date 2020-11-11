using System;
using System.Collections.Generic;


namespace Reservaciones
{

    public class Reservar
{
    public List<Habitaciones> ListadeHabitaciones { get; set; }

 
 public Reservar()
 {
     ListadeHabitaciones = new List<Habitaciones>();
     cargarHabitaciones();
 }

 public void cargarHabitaciones(){
     Habitaciones r1 = new Habitaciones(1, 5, "Sencilla");
     ListadeHabitaciones.Add(r1);

     Habitaciones r2 = new Habitaciones(2, 5, "Doble");
     ListadeHabitaciones.Add(r2);

     Habitaciones r3 = new Habitaciones(3, 5, "Triple");
     ListadeHabitaciones.Add(r3);

     Habitaciones r4 = new Habitaciones(4, 5, "Cuadruple");
     ListadeHabitaciones.Add(r4);

     Habitaciones r5 = new Habitaciones(5, 5, "Suite");
     ListadeHabitaciones.Add(r5);

     Habitaciones r6 = new Habitaciones(6, 4, "Sencilla");
     ListadeHabitaciones.Add(r6);

     Habitaciones r7 = new Habitaciones(7, 4, "Presidencial");
     ListadeHabitaciones.Add(r7);

     Habitaciones r8 = new Habitaciones(8, 4, "Doble");
     ListadeHabitaciones.Add(r8);

     Habitaciones r9 = new Habitaciones(9, 4, "Triple");
     ListadeHabitaciones.Add(r9);

     Habitaciones r10 = new Habitaciones(10, 4, "Cuadruple");
     ListadeHabitaciones.Add(r10);

     Habitaciones r11 = new Habitaciones(11, 3, "Triple");
     ListadeHabitaciones.Add(r11);

     Habitaciones r12 = new Habitaciones(12, 3, "Doble");
     ListadeHabitaciones.Add(r12);

     Habitaciones r13 = new Habitaciones(13, 2, "Suite");
     ListadeHabitaciones.Add(r13);

     Habitaciones r14 = new Habitaciones(14, 3, "Sencilla");
     ListadeHabitaciones.Add(r14);

     Habitaciones r15 = new Habitaciones(15, 3, "Cinco Estrellas");
     ListadeHabitaciones.Add(r15);
 }
 public void listarHabitaciones(){
     Console.Clear();
     Console.WriteLine("Habitaciones Disponibles");
     Console.WriteLine("************************");
     Console.WriteLine("Habitacion | Piso | Tipo");
     Console.WriteLine("");

     foreach (var habitacion in ListadeHabitaciones)
        {
            Console.WriteLine(habitacion.Numero + "|" + habitacion.Piso + "|" + habitacion.Tipo);
        }  
        Console.ReadLine();
     }
}
    class Program
    {
        static void Main(string[] args)
        {

           Reservar reserva = new Reservar();
           string opcion = "";

           while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Habitaciones");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        reserva.listarHabitaciones();
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
