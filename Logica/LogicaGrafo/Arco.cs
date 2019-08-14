namespace Logica.LogicaGrafo
{
    public class Arco
    {
        public Vertice VerticeDestino { get; set; }
        public decimal Kilometros { get; set; }
        public Arco Siguiente { get; set; }

        public Arco()
        {

        }

        public Arco(Vertice nDestino, decimal nKm)
        {
            VerticeDestino = nDestino;
            Kilometros = nKm;
        }
    }
}
