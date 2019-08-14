namespace Logica.LogicaGrafo
{
    public class ListaArco
    {
        public Arco Cabeza { get; set; }

        public ListaArco()
        {
            Cabeza = null;
        }

        public bool Insertar(Arco nArco)
        {
            var insertado = false;

            if(nArco != null)
            {
                if (!EsVacio())
                {
                    nArco.Siguiente = Cabeza;
                }

                Cabeza = nArco;
                insertado = true;
            }

            return insertado;
        }

        public Arco Buscar(Vertice destino)
        {
            var aux = Cabeza;
            Arco encontrado = null;

            while(aux != null)
            {
                if (aux.VerticeDestino.Nombre.Equals(destino.Nombre))
                {
                    encontrado = aux;
                    break;
                }

                aux = aux.Siguiente;
            }

            return encontrado;
        }

        private bool EsVacio()
        {
            var esVacio = false;

            if(Cabeza == null)
            {
                esVacio = true;
            }

            return esVacio;
        }
    }
}
