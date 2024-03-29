﻿namespace Logica.LogicaGrafo
{
    public class Vertice
    {
        public string Nombre { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public ListaArco Arcos { get; set; }
        public Vertice Siguiente { get; set; }

        public Vertice()
        {
            Arcos = new ListaArco();
        }

        public Vertice(string nNombre, double nLat, double nLong)
        {
            Arcos = new ListaArco();
            Nombre = nNombre;
            Latitud = nLat;
            Longitud = nLong;
        }

    }
}
