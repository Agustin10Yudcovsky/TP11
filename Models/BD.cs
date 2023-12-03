using System.Data.SqlClient;
using Dapper;

public static class BD{
    private static string ConnectionString {get; set;} = @"Server=localhost;DataBase=BDBoca;Trusted_Connection=True;";

    public static List<Partido> ObtenerPartidos(){
        List<Partido> user = new List<Partido>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Partidos";
            user = db.Query<Partido>(sql).ToList();
        }
        return user;
    }

    public static List<Entradas> ObtenerEntradas(){
        List<Entradas> user = new List<Entradas>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Entradas";
            user = db.Query<Entradas>(sql).ToList();
        }
        return user;
    }

    public static List<Noticias> ObtenerNoticias(){
        List<Noticias> user = new List<Noticias>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Noticia";
            user = db.Query<Noticias>(sql).ToList();
        }
        return user;
    }
}