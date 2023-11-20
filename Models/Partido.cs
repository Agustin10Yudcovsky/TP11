public class Partido{
    public int PartidoId {get;set;}
    public DateTime Fechapartido {get;set;}
    public string Rival {get;set;}
    public string Fotorival {get;set;}

    public Partido(){

    }

    public Partido(int partidoid, DateTime fechapartido, string rival, string fotorival){
        PartidoId = partidoid;
        Fechapartido = fechapartido;
        Rival = rival;
        Fotorival = fotorival;
    }
}