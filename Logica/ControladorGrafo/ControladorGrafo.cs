using Logica.LogicaGrafo;
using Logica.LogicaHash;
using ProyectoEstructuras2;
using System.Collections.Generic;


namespace Logica.ControladorGrafo
{
    /// <summary>
    /// Esta clase se encarga de la comunicacion entre la UI y la clase ListaVertice.
    /// </summary>
    public class ControladorGrafo
    {
        public static ListaVertice Vertices;

        public ControladorGrafo()
        {
            Vertices = new ListaVertice();
            InicializarListaVertice();
            InitListaArcos();
        }

        /// <summary>
        /// Responsable de retornar una lista de vertices.
        /// </summary>
        /// <returns></returns>
        public List<Vertice> ObtenerVertices()
        {
            return Vertices.ToList();
        }

        public HashingTable ObtenerHashTable()
        {
            HashingTable hashtable = new HashingTable();
            List<Vertice> listaTemp = ObtenerVertices();
            foreach (var vertice in listaTemp)
            {
                if (!hashtable.ContainsKey(vertice.Nombre.ToLower()))
                {
                    hashtable.Add(vertice.Nombre.ToLower(), vertice);
                }
                else
                {
                    throw new System.Exception("HashTable contains duplicated key.");
                }
            }
            return hashtable;
        }



        /// <summary>
        /// Es responsable de inicializar los vertices a utilizar.
        /// </summary>
        private void InicializarListaVertice()
        {
            //1
            var nVer1 = new Vertice { Nombre = "Universidad Nacional", Latitud = 9.999962, Longitud = -84.111398 };
            Vertices.Insertar(nVer1);

            //2
            nVer1 = new Vertice { Nombre = "El Fortín", Latitud = 10.000427, Longitud = -84.117063 };
            Vertices.Insertar(nVer1);

            //3
            nVer1 = new Vertice { Nombre = "Aeropuerto Internacional Juan Santamaría", Latitud = 9.998766, Longitud = -84.204073 };
            Vertices.Insertar(nVer1);

            //4
            nVer1 = new Vertice { Nombre = "zoo Ave", Latitud = 10.012480, Longitud = -84.275422 };
            Vertices.Insertar(nVer1);

            //5
            nVer1 = new Vertice { Nombre = "San Antonio de Belen", Latitud = 9.978756, Longitud = -84.204073 };
            Vertices.Insertar(nVer1);

            //6
            nVer1 = new Vertice { Nombre = "Parque de diversiones", Latitud = 9.961281, Longitud = -84.128052 };
            Vertices.Insertar(nVer1);

            //7
            nVer1 = new Vertice { Nombre = "Hospital México", Latitud = 9.951550, Longitud = -84.115071 };
            Vertices.Insertar(nVer1);

            //8
            nVer1 = new Vertice { Nombre = "AyA", Latitud = 9.937973, Longitud = -84.119519 };
            Vertices.Insertar(nVer1);

            //9
            nVer1 = new Vertice { Nombre = "Estadio Nacional", Latitud = 9.937014, Longitud = -84.107783 };
            Vertices.Insertar(nVer1);

            //10
            nVer1 = new Vertice { Nombre = "Parque Central", Latitud = 9.933204, Longitud = -84.079662 };
            Vertices.Insertar(nVer1);

            //11
            nVer1 = new Vertice { Nombre = "Catedral Metropolitana", Latitud = 9.932782, Longitud = -84.078771 };
            Vertices.Insertar(nVer1);

            //12
            nVer1 = new Vertice { Nombre = "Teatro Nacional", Latitud = 9.933310, Longitud = -84.077195 };
            Vertices.Insertar(nVer1);

            //13
            nVer1 = new Vertice { Nombre = "Estacion de trenes al Pacifico", Latitud = 9.925545, Longitud = -84.080619 };
            Vertices.Insertar(nVer1);

            //14
            nVer1 = new Vertice { Nombre = "Museo Nacional de Costa Rica", Latitud = 9.933506, Longitud = -84.071677 };
            Vertices.Insertar(nVer1);

            //15
            nVer1 = new Vertice { Nombre = "Parque Morazán", Latitud = 9.935684, Longitud = -84.075394 };
            Vertices.Insertar(nVer1);

            //16
            nVer1 = new Vertice { Nombre = "Hospital Calderón Guardia", Latitud = 9.937001, Longitud = -84.069439 };
            Vertices.Insertar(nVer1);

            //17
            nVer1 = new Vertice { Nombre = "Estación del Ferrocarril al Atlántico", Latitud = 9.934748, Longitud = -84.068853 };
            Vertices.Insertar(nVer1);

            //18
            nVer1 = new Vertice { Nombre = "Lupulus Beer Shop", Latitud = 9.935899, Longitud = -84.062038 };
            Vertices.Insertar(nVer1);

            //19
            nVer1 = new Vertice { Nombre = "Parque de la paz", Latitud = 9.913378, Longitud = -84.072238 };
            Vertices.Insertar(nVer1);

            //20
            nVer1 = new Vertice { Nombre = "Mall San Pedro", Latitud = 9.933496, Longitud = -84.056588 };
            Vertices.Insertar(nVer1);

            //21
            nVer1 = new Vertice { Nombre = "Hospital la Catolica", Latitud = 9.950094, Longitud = -84.058953 };

            Vertices.Insertar(nVer1);

            //22
            nVer1 = new Vertice { Nombre = "Universidad de Costa Rica", Latitud = 9.938262, Longitud = -84.051131 };
            Vertices.Insertar(nVer1);

            //23
            nVer1 = new Vertice { Nombre = "Multiplaza Curridabat", Latitud = 9.918141, Longitud = -84.046839 };
            Vertices.Insertar(nVer1);

            //24
            nVer1 = new Vertice { Nombre = "Universidad Cenfotec", Latitud = 9.932410, Longitud = -84.031022 };
            Vertices.Insertar(nVer1);

            //25
            nVer1 = new Vertice { Nombre = "TEC", Latitud = 9.856760, Longitud = -83.911665 };
            Vertices.Insertar(nVer1);

        }

        private void InitListaArcos()
        {
            var calculador = new Calculador();
            var listVertices = ObtenerVertices();

            //Arco 1
            var startVertice = listVertices[0];
            var endVertice = listVertices[1];
            var km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            var arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 2
            startVertice = listVertices[1];
            endVertice = listVertices[2];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 3
            startVertice = listVertices[2];
            endVertice = listVertices[3];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 4
            startVertice = listVertices[3];
            endVertice = listVertices[4];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 5
            startVertice = listVertices[4];
            endVertice = listVertices[5];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 6
            startVertice = listVertices[5];
            endVertice = listVertices[6];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 7
            startVertice = listVertices[6];
            endVertice = listVertices[7];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 8
            startVertice = listVertices[7];
            endVertice = listVertices[8];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 9
            startVertice = listVertices[8];
            endVertice = listVertices[9];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 10
            startVertice = listVertices[9];
            endVertice = listVertices[10];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 11
            startVertice = listVertices[10];
            endVertice = listVertices[11];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 12
            startVertice = listVertices[11];
            endVertice = listVertices[12];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 13
            startVertice = listVertices[12];
            endVertice = listVertices[13];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 14
            startVertice = listVertices[13];
            endVertice = listVertices[14];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 15
            startVertice = listVertices[14];
            endVertice = listVertices[15];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 16
            startVertice = listVertices[15];
            endVertice = listVertices[16];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 17
            startVertice = listVertices[16];
            endVertice = listVertices[17];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 18
            startVertice = listVertices[17];
            endVertice = listVertices[18];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 19
            startVertice = listVertices[18];
            endVertice = listVertices[19];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 20
            startVertice = listVertices[19];
            endVertice = listVertices[20];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 21
            startVertice = listVertices[20];
            endVertice = listVertices[21];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 22
            startVertice = listVertices[21];
            endVertice = listVertices[22];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 23
            startVertice = listVertices[22];
            endVertice = listVertices[23];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            //Arco 24
            startVertice = listVertices[23];
            endVertice = listVertices[24];
            km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            startVertice.Arcos.Insertar(arco);

            ////Arco 25
            //startVertice = listVertices[24];
            //endVertice = listVertices[25];
            //km = calculador.CalculateKilometers(startVertice.Latitud, startVertice.Longitud, endVertice.Latitud, endVertice.Longitud);
            //arco = new Arco { VerticeDestino = endVertice, Kilometros = km };
            //startVertice.Arcos.Insertar(arco);
        }
    }
}
