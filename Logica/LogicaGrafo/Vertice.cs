namespace Logica.LogicaGrafo
{
    public class Vertice
    {
        public string Nombre { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public ListaArco Arcos { get; set; }
        public Vertice Siguiente { get; set; }

        public Vertice()
        {

        }

        public Vertice(string nNombre, decimal nLat, decimal nLong)
        {
            Nombre = nNombre;
            Latitud = nLat;
            Longitud = nLong;
        }
    }
}
