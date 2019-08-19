namespace Logica.LogicaGrafo
{
    public class Arco
    {
        public Vertice VerticeDestino { get; set; }
        public double Kilometros { get; set; }
        public Arco Siguiente { get; set; }

        public Arco()
        {

        }

        public Arco(Vertice nDestino, double nKm)
        {
            VerticeDestino = nDestino;
            Kilometros = nKm;
        }
    }
}
