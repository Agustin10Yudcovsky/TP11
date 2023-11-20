using System.Data.SqlClient;
using Dapper;

public static class BD{
    private static string ConnectionString {get; set;} = @"Server=DESKTOP-5VP95V6\SQLEXPRESS;DataBase=BDBoca;Trusted_Connection=True;";

    public static List<Partido> ObtenerPartidos(){
        List<Partido> user = new List<Partido>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Partidos";
            user = db.Query<Partido>(sql).ToList();
        }
        return user;
    }

      
}