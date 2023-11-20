using System.Data.SqlClient;
using Dapper;

public static class BD{
    private static string ConnectionString {get; set;} = @"Server=localhost;DataBase=BDBocaWeb;Trusted_Connection=True;";


      public static void CrearUsuario(string Username, string Contrasena, string Nombre, string Apellido, string Email, string preguntaSeguridad){
        using (SqlConnection db = new SqlConnection(ConnectionString)){
            string sql = "INSERT INTO Usuario(username, contrasena, nombre, apellido, email, preguntaSeguridad) VALUES (@Usuario, @Contra, @Nom, @Ape, @Em, @PS)";
            db.Execute(sql, new {Usuario = Username, Contra = Contrasena, Nom = Nombre, Ape = Apellido, Em = Email, PS = preguntaSeguridad});
        }
    }
}