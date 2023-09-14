public class Alumno{
    public int idAlumno {get; set;}
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int Legajo {get; set;}
    public int idCurso {get; set;}

    public Alumno(){}

    public Alumno (string nombre, string apellido, int legajo, int idcurso){
        Nombre = nombre;
        Apellido = apellido;
        Legajo = legajo;
        idCurso = idcurso;
    }
}