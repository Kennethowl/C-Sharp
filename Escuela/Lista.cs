
    public class Lista{

     public string  Nombre { get; set; }
     public string Apellido { get; set; }
     public bool Activo { get; set; }

     public Lista(string nombre, string apellido)
    {
      
        Nombre = nombre;
        Apellido = apellido;
        Activo = true;
    }

    public string nombreCompleto(){
        if(Activo == true){
        return Nombre + " " + Apellido;  
        }
        return "Alumno Inactivo";
    }

    public void inactivarAlumno(){
        Activo = false;
    }

     public void activarAlumno(){
        Activo = true;
    }

}