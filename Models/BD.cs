using System.Data.SqlClient;
using Dapper;

public static class BD{
    private static string ConnectionString {get; set;} = @"Server=DESKTOP-GD7LDGF\SQLEXPRESS01;DataBase=BDBoca;Trusted_Connection=True;";

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
            string sql = "SELECT * FROM Entradas WHERE Disponible ='True'";
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

    public static void ActualizarEntrada(int entradaid){
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "UPDATE Entradas SET Disponible = 'false' WHERE EntradaID = @pentradaid;";
            db.Execute(sql, new{pentradaid = entradaid});
        }
    
    }
    public static List<Entradas> ObtenerEntradasPorPartido(int PartidoID){
        List<Entradas> user = new List<Entradas>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Entradas WHERE Disponible ='True' and PartidoID=@PartidoIDp";
            user = db.Query<Entradas>(sql, new{PartidoIDp = PartidoID } ).ToList();
        }
        return user;
    }
    public static List<Entradas> ObtenerEntradasId(int idpartido){
        List<Entradas> user = new List<Entradas>();
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "SELECT * FROM Entradas WHERE Disponible ='True' AND PartidoID = @pidpartido";
            user = db.Query<Entradas>(sql, new{pidpartido = idpartido}).ToList();
        }
        return user;
    }
 
}