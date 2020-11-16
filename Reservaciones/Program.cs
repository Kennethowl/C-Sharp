using System;
using System.Collections.Generic;


namespace Reservaciones
{

    public class Reservar
{
    public List<Habitaciones> ListadeHabitaciones { get; set; }
    public List<Restaurante> MenuedeRestaurante { get; set; }
    public List<Clientela> ListadeClientes { get; set; }
    public List<CrearReserva> ListadeReservas { get; set; }
    

 
 public Reservar()
 {
     ListadeHabitaciones = new List<Habitaciones>();
     cargarHabitaciones();
     MenuedeRestaurante = new List<Restaurante>();
     cargarMenu();
     ListadeClientes = new List<Clientela>();
     cargarClientes();
     ListadeReservas = new List<CrearReserva>();
 }

 public void cargarHabitaciones(){
     Habitaciones r1 = new Habitaciones(1, 5, "Sencilla", 600, "1");
     ListadeHabitaciones.Add(r1);

     Habitaciones r2 = new Habitaciones(2, 5, "Doble", 1000, "2");
     ListadeHabitaciones.Add(r2);

     Habitaciones r3 = new Habitaciones(3, 5, "Triple", 1500, "3");
     ListadeHabitaciones.Add(r3);

     Habitaciones r4 = new Habitaciones(4, 5, "Cuadruple", 2000, "4");
     ListadeHabitaciones.Add(r4);

     Habitaciones r5 = new Habitaciones(5, 5, "Suite", 5000, "5");
     ListadeHabitaciones.Add(r5);

     Habitaciones r6 = new Habitaciones(6, 4, "Sencilla", 600, "6");
     ListadeHabitaciones.Add(r6);

     Habitaciones r7 = new Habitaciones(7, 4, "Presidencial", 10000, "7");
     ListadeHabitaciones.Add(r7);

     Habitaciones r8 = new Habitaciones(8, 4, "Doble", 1000, "8");
     ListadeHabitaciones.Add(r8);

     Habitaciones r9 = new Habitaciones(9, 4, "Triple", 1500, "9");
     ListadeHabitaciones.Add(r9);

     Habitaciones r10 = new Habitaciones(10, 4, "Cuadruple", 2000, "10");
     ListadeHabitaciones.Add(r10);

     Habitaciones r11 = new Habitaciones(11, 3, "Triple", 1500, "11");
     ListadeHabitaciones.Add(r11);

     Habitaciones r12 = new Habitaciones(12, 3, "Doble", 1000, "12");
     ListadeHabitaciones.Add(r12);

     Habitaciones r13 = new Habitaciones(13, 3, "Suite", 5000, "13");
     ListadeHabitaciones.Add(r13);

     Habitaciones r14 = new Habitaciones(14, 3, "Sencilla", 600, "14");
     ListadeHabitaciones.Add(r14);

     Habitaciones r15 = new Habitaciones(15, 3, "Cinco Estrellas", 6000, "15");
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
      Restaurante menu1 = new Restaurante("Osmil", 30, "Pollo con Tajadas", 90,  "Caviar", 2000);
      MenuedeRestaurante.Add(menu1);
      Restaurante menu2 = new Restaurante("Baleada sencilla", 14, "Bariloche Burger", 100,  "Cena patagonica", 300);
      MenuedeRestaurante.Add(menu2);
      Restaurante menu3 = new Restaurante("Baleada con Pollo", 17, "Especial de Papas", 30,  "Cena Cinco Estrellas", 2000);
      MenuedeRestaurante.Add(menu3);
      Restaurante menu4 = new Restaurante("Cafe con Budin", 10, "Pizza", 99,  "Cena Bufete", 70);
      MenuedeRestaurante.Add(menu4);
  }

  public void menuRestaurante(){
     Console.Clear();
     Console.WriteLine("Menu Bariloche's Restaurant");
     Console.WriteLine("***************************");
     Console.WriteLine("Desayuno | Precio | Almuerzo | Precio | Cena | Precio");
     Console.WriteLine("");

     foreach (var servicio in MenuedeRestaurante)
        {
            Console.WriteLine( servicio.Desayuno + " | " + servicio.Saldo1 + " | " + servicio.Almuerzo + " | " + servicio.Saldo2 + " | " + servicio.Cena + " | " + servicio.Saldo3);
        }  
        Console.ReadLine();
     }
   
    public void cargarClientes(){
        Clientela c1 = new Clientela(123, 180, "Gisel", "Membreño", 97789612, "1");
        ListadeClientes.Add(c1);
        Clientela c2 = new Clientela(456, 181, "Juan", "Carlos", 32562314, "2");
        ListadeClientes.Add(c2);
        Clientela c3 = new Clientela(455, 182, "Acsa", "Salazar", 97781214, "3");
        ListadeClientes.Add(c3);
        Clientela c4 = new Clientela(457, 183, "Kenneth", "Flores", 33532334, "4");
        ListadeClientes.Add(c4);

    }

    public void listarClientes(){
     Console.Clear();
     Console.WriteLine("  Lista de Clientes  ");
     Console.WriteLine("************************");
     Console.WriteLine(" Codigo | Identidad | Nombre | Apellido | Telefono ");
     Console.WriteLine("");
     
     foreach (var cliente in ListadeClientes)
     {
         Console.WriteLine(cliente.Codigo + " | " + cliente.ID + " | " + cliente.Nombre + " | " + cliente.Apellido + " | " + cliente.Telefono);
     }
     
     
     Console.ReadLine();

    }

    public void asignarReserva(){
        Console.WriteLine("Creando Reserva");
        Console.WriteLine("=============");
        Console.WriteLine("");

        
        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigocliente = Console.ReadLine();

        Clientes cliente = ListadeClientes.Find(c => c.Codigo.ToString() == codigocliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre + " | " + cliente.Apellido);
            Console.WriteLine("");
        }

         Console.WriteLine("Ingrese el numero de habitacion: ");
        string codigoHabitacion = Console.ReadLine();

        Habitaciones habitacion = ListadeHabitaciones.Find(v => v.Numero.ToString() == codigoHabitacion);
        if (habitacion == null) 
        {
            Console.WriteLine("Habitacion no encontrada");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Habitacion: " + " Numero: "  + habitacion.Numero + " | " + "Piso: " + habitacion.Piso + " | " + "Tipo: " + habitacion.Tipo + " | " + "Saldo: " + habitacion.Precio);
            Console.WriteLine("");
            Console.ReadLine();
        }
    }

}
public class Restaurante
{
    public string Desayuno { get; set; }
    public double Saldo1 { get; set; }
    public string Almuerzo { get; set; }
    public double  Saldo2 { get; set; }
    public string  Cena { get; set; }
    public double Saldo3 { get; set; }

    public Restaurante(string desayuno, double saldo1, string almuerzo, double saldo2, string cena, double saldo3)
    {
        Desayuno = desayuno;
        Saldo1 = saldo1;
        Almuerzo = almuerzo;
        Saldo2 = saldo2;
        Cena = cena;
        Saldo3 = saldo3;
    }
}

public class Clientela : Clientes 
{
    public string CodigoCliente { get; set; }
   
public Clientela(int codigo, int id, string nombre, string apellido, int telefono, string codigocliente)
    {
        Codigo = codigo;
        ID = id;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        CodigoCliente = codigocliente;

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
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Crear Reserva");
                Console.WriteLine("5 - Reservaciones Hechas");
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
