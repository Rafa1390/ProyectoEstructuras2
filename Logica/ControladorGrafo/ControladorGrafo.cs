using Logica.LogicaGrafo;
using Logica.LogicaHash;
using System.Collections;
using System.Collections.Generic;

namespace Logica.ControladorGrafo
{
    public class ControladorGrafo
    {
        public static ListaVertice Vertices;

        public ControladorGrafo()
        {
            Vertices = new ListaVertice();
            InicializarListaVertice();
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
            foreach(var vertice in listaTemp)
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
    }
}
