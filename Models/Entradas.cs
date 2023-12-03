public class Entradas
{
    public int EntradaID { get; set; }
    public int Precio { get; set; }
    public string Asiento { get; set; }
    public int PartidoId { get; set; }


    public Entradas(){}

    public Entradas(int entradaid, int precio, string asiento, int partidoid){
        EntradaID=entradaid;
        Precio=precio;
        Asiento=asiento;
        PartidoId=partidoid;
    }
}