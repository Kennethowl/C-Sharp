using System;

namespace pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("DINOSAURIOS");
            Console.WriteLine("");
            
            Tiranosaurio tiranosaurio = new Tiranosaurio();
            tiranosaurio.Nombre = "Tiranosaurio Rex";
            tiranosaurio.Familia = "Tiranosauridae";
            tiranosaurio.Orden = "Saurischia";
            tiranosaurio.Teropodo = true;
            tiranosaurio.Periodo = "Cretacico Superior";
            tiranosaurio.metodo();
            tiranosaurio.tamanio();

            Console.WriteLine("Nombre: " + tiranosaurio.Nombre);
            Console.WriteLine("Familia: " + tiranosaurio.Familia);
            Console.WriteLine("Orden: " + tiranosaurio.Orden);
            Console.WriteLine("Suborden: Teropodo " + tiranosaurio.Teropodo);
            Console.WriteLine("Periodo: " + tiranosaurio.Periodo);

            Console.WriteLine("");
            Console.WriteLine("");

            Allosaurus allosaurus = new Allosaurus();
            allosaurus.Nombre = "Allosaurus Fragilis";
            allosaurus.Familia = "Allosauridae";
            allosaurus.Orden = "Saurischia";
            allosaurus.Teropodo = true;
            allosaurus.Periodo = "Jurasico Superior";
            allosaurus.metodo();
            allosaurus.tamanio();

            Console.WriteLine("Nombre: " + allosaurus.Nombre);
            Console.WriteLine("Familia: " + allosaurus.Familia);
            Console.WriteLine("Orden: " + allosaurus.Orden);
            Console.WriteLine("Suborden: Teropodo " + allosaurus.Teropodo);
            Console.WriteLine("Periodo: " + allosaurus.Periodo);
            


            
        }
    }
}
