using System.Security.Cryptography;
using System.Data;
using System;
using Dapper;
using System.Linq;
using System.Threading;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


public static class BD
{
    private static string _connectionString = "Server=localhost;DataBase=GestionAlumnos;Trusted_Connection=True;";

    public static List<Alumno> ObtenerAlumnos(){
        string sql = "SELECT * FROM Alumnos;";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            return db.Query<Alumno>(sql).ToList();
        }
    }

    public static List<Curso> ObtenerCursos(){
        string sql = "SELECT * FROM Cursos;";
        using (SqlConnection db = new SqlConnection(_connectionString))
        {
            return db.Query<Curso>(sql).ToList();
        }
    }

    public static Alumno ObtenerAlumno(int idAlumno){
        string sql = "SELECT * FROM Alumnos WHERE idAlumno = @idAlumno;";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.QueryFirstOrDefault<Alumno>(sql, new {idAlumno});
        }
    }

    public static Curso ObtenerCurso(int idCurso){
        string sql = "SELECT * FROM Cursos WHERE idCurso = @idCurso;";
        using (SqlConnection db = new SqlConnection(_connectionString)){
            return db.QueryFirstOrDefault<Curso>(sql, new {idCurso});
        }
    }
}