public class Curso{
    public int idCurso {get; set;}
    public int Ano {get; set;}
    public char Division {get; set;}

    public Curso(){}

    public Curso(int ano, char division){
        Ano = ano;
        Division = division;
    }
}