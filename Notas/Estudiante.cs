public class Estudiante : Persona
{
 public string Sexo { get; set; }

 public Estudiante(string codigo, int carnet, string nombre, string apellido, string sexo )
 {
     Codigo = codigo;
     Carnet = carnet;
     Nombre = nombre;
     Apellido = apellido;
     Sexo = sexo;
 }
}