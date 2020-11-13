using System;
using System.Collections.Generic;


namespace Reservaciones
{

    public class Reservar
{
    public List<Habitaciones> ListadeHabitaciones { get; set; }
    public List<Servicio> MenuedeRestaurante { get; set; }
    

 
 public Reservar()
 {
     ListadeHabitaciones = new List<Habitaciones>();
     cargarHabitaciones();
     MenuedeRestaurante = new List<Servicio>();
     cargarMenu();
 }

 public void cargarHabitaciones(){
     Habitaciones r1 = new Habitaciones(1, 5, "Sencilla", 600);
     ListadeHabitaciones.Add(r1);

     Habitaciones r2 = new Habitaciones(2, 5, "Doble", 1000);
     ListadeHabitaciones.Add(r2);

     Habitaciones r3 = new Habitaciones(3, 5, "Triple", 1500);
     ListadeHabitaciones.Add(r3);

     Habitaciones r4 = new Habitaciones(4, 5, "Cuadruple", 2000);
     ListadeHabitaciones.Add(r4);

     Habitaciones r5 = new Habitaciones(5, 5, "Suite", 5000);
     ListadeHabitaciones.Add(r5);

     Habitaciones r6 = new Habitaciones(6, 4, "Sencilla", 600);
     ListadeHabitaciones.Add(r6);

     Habitaciones r7 = new Habitaciones(7, 4, "Presidencial", 10000);
     ListadeHabitaciones.Add(r7);

     Habitaciones r8 = new Habitaciones(8, 4, "Doble", 1000);
     ListadeHabitaciones.Add(r8);

     Habitaciones r9 = new Habitaciones(9, 4, "Triple", 1500);
     ListadeHabitaciones.Add(r9);

     Habitaciones r10 = new Habitaciones(10, 4, "Cuadruple", 2000);
     ListadeHabitaciones.Add(r10);

     Habitaciones r11 = new Habitaciones(11, 3, "Triple", 1500);
     ListadeHabitaciones.Add(r11);

     Habitaciones r12 = new Habitaciones(12, 3, "Doble", 1000);
     ListadeHabitaciones.Add(r12);

     Habitaciones r13 = new Habitaciones(13, 3, "Suite", 5000);
     ListadeHabitaciones.Add(r13);

     Habitaciones r14 = new Habitaciones(14, 3, "Sencilla", 600);
     ListadeHabitaciones.Add(r14);

     Habitaciones r15 = new Habitaciones(15, 3, "Cinco Estrellas", 6000);
     ListadeHabitaciones.Add(r15);
 
 }

 public void listarHabitaciones(){
     Console.Clear();
     Console.WriteLine("Habitaciones Disponibles");
     Console.WriteLine("************************");
     Console.WriteLine("Habitacion | Piso | Tipo | Precio");
     Console.WriteLine("");

     foreach (var habitacion in ListadeHabitaciones)
        {
            Console.WriteLine(habitacion.Numero + " | " + habitacion.Piso + " | " + habitacion.Tipo + " | " + habitacion.Precio);
        }  
        Console.ReadLine();
     }

  public void cargarMenu(){
      Servicio menu1 = new Servicio("Osmil", 30, "Pollo con Tajadas", 90,  "Caviar", 2000);
      MenuedeRestaurante.Add(menu1);
      Servicio menu2 = new Servicio("Baleada sencilla", 14, "Bariloche Burger", 100,  "Cena patagonica", 300);
      MenuedeRestaurante.Add(menu2);
      Servicio menu3 = new Servicio("Baleada con Pollo", 17, "Especial de Papas", 30,  "Cena Cinco Estrellas", 2000);
      MenuedeRestaurante.Add(menu3);
      Servicio menu4 = new Servicio("Cafe con Budin", 10, "Pizza", 99,  "Cena Bufete", 70);
      MenuedeRestaurante.Add(menu4);
  }

  public void menuRestaurante(){
     Console.Clear();
     Console.WriteLine("Menu Bariloche's Restaurant");
     Console.WriteLine("************************");
     Console.WriteLine("Desayuno | Precio | Almuerzo | Precio | Cena | Precio");
     Console.WriteLine("");

     foreach (var servicio in MenuedeRestaurante)
        {
            Console.WriteLine( servicio.Desayuno + " | " + servicio.Saldo1 + " | " + servicio.Almuerzo + " | " + servicio.Saldo2 + " | " + servicio.Cena + " | " + servicio.Saldo3);
        }  
        Console.ReadLine();
     }

    public void listarReservas(){
     Console.Clear();
     Console.WriteLine("  Reservaciones Hechas  ");
     Console.WriteLine("************************");
     Console.WriteLine("Nombre | Apellido | Identidad | Telefono | Fecha | Habitacione | Tipo | Precio");
     Console.WriteLine("");
     Console.ReadLine();

    }
}
public class Servicio
{
    public string Desayuno { get; set; }
    public double Saldo1 { get; set; }
    public string Almuerzo { get; set; }
    public double  Saldo2 { get; set; }
    public string  Cena { get; set; }
    public double Saldo3 { get; set; }

    public Servicio(string desayuno, double saldo1, string almuerzo, double saldo2, string cena, double saldo3)
    {
        Desayuno = desayuno;
        Saldo1 = saldo1;
        Almuerzo = almuerzo;
        Saldo2 = saldo2;
        Cena = cena;
        Saldo3 = saldo3;
    }
}

public class CrearReserva : Clientes
{
    public DateTime Fecha { get; set; }
    public Habitaciones Numero { get; set; }
    public Habitaciones Tipo { get; set; }
    public Habitaciones Precio { get; set; }

public CrearReserva (int codigo, int id, string nombre, string apellido, int telefono, DateTime fecha, Habitaciones numero, Habitaciones tipo, Habitaciones precio)
    {
        Codigo = codigo;
        ID = id;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        Fecha = fecha;
        Numero = numero;
        Tipo = tipo;
        Precio = precio;
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
                Console.WriteLine("  Hotel Flores ");
                Console.WriteLine("****************");
                Console.WriteLine("");
                Console.WriteLine("1 - Habitaciones");
                Console.WriteLine("2 - Bariloche's Restaurant");
                Console.WriteLine("3 - Lista de Habitaciones Reservadas");
                Console.WriteLine("4 - Crear Reserva");
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
                        reserva.listarReservas();
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
