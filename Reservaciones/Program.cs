﻿using System;
using System.Collections.Generic;


namespace Reservaciones
{
    class Program
    {
        static void Main(string[] args)
        {

           Reservar reserva = new Reservar();
           string opcion = "";

           while (true)
            {
                Console.Clear();
                Console.WriteLine("  Hotel Flores ");
                Console.WriteLine("****************");
                Console.WriteLine("");
                Console.WriteLine("1 - Habitaciones");
                Console.WriteLine("2 - Bariloche's Restaurant");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Crear Reserva");
                Console.WriteLine("5 - Reservaciones ");
                Console.WriteLine("6 - Creditos");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        reserva.listarHabitaciones();
                        break;
                    case "2":
                        reserva.menuRestaurante();
                        break;
                    case "3":
                        reserva.listarClientes();
                        break;
                    case "4":
                        reserva.asignarReserva();
                        break;
                    case "5":
                        break; 
                    case "6":
                        reserva.creditos();
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
