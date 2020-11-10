public class Clientes{
    public int Codigo { get; set; }
    public int ID { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Telefono { get; set; }

    public Clientes(int codigo, int id, string nombre, string apellido, int telefono)
    {
        Codigo = codigo;
        ID = id;
        Nombre = nombre;
        Apellido = apellido;
        Telefono = telefono;
        
    }
}