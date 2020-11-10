public class Habitaciones
{
    public int Numero { get; set; }
    public int Piso { get; set; }
    public string Tipo { get; set; }
    
    public Habitaciones(int numero, int piso, string tipo)
    {
        Numero = numero;
        Piso = piso;
        Tipo = tipo;
    }
}