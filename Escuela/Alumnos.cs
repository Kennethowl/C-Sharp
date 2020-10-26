public class Alumno {

    public int Codigo { get; set; }
    public string  Nombre { get; set; }
    public int  Carnet { get; set; }

    public Alumno(int codigo, string nombre, int carnet)
    {
        Codigo = codigo;
        Nombre = nombre;
        Carnet = carnet;
    }
}
