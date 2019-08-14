using Logica.LogicaGrafo;
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

        /// <summary>
        /// Es responsable de inicializar los vertices a utilizar.
        /// </summary>
        private void InicializarListaVertice()
        {
            //1
            var nVer1 = new Vertice { Nombre = "Provincia San José, San Pedro, 11905 Costa Rica", Latitud = 9.2794686, Longitud = -83.5499635 };
            Vertices.Insertar(nVer1);

            //2
            nVer1 = new Vertice { Nombre = "Cantón Moravia, Costa Rica", Longitud = -84.0094218, Latitud = 10.0139444 };
            Vertices.Insertar(nVer1);

            //3
            nVer1 = new Vertice { Nombre = "Cantón Curridabat, Costa Rica", Latitud = 9.9251453, Longitud= -84.0317621 };
            Vertices.Insertar(nVer1);

            //4
            nVer1 = new Vertice { Nombre = "Cantón Santa Ana, Costa Rica", Latitud = 9.9184374, Longitud = -84.1915718 };
            Vertices.Insertar(nVer1);

            //5
            nVer1 = new Vertice { Nombre = "Cantón Atenas, Costa Rica", Latitud = 9.9795178, Longitud = -84.3991733 };
            Vertices.Insertar(nVer1);

            //6
            nVer1 = new Vertice { Nombre = "Cantón Grecia, Costa Rica", Latitud = 10.092686, Longitud = -84.2990071 };
            Vertices.Insertar(nVer1);

            //7
            nVer1 = new Vertice { Nombre = "Cantón San Ramón, Costa Rica", Latitud = 10.218161, Longitud = -84.5720736 };
            Vertices.Insertar(nVer1);

            //8
            nVer1 = new Vertice { Nombre = "Cantón Barva, Costa Rica", Latitud = 10.0763486, Longitud = -84.109221 };
            Vertices.Insertar(nVer1);

            //9
            nVer1 = new Vertice { Nombre = "Cantón San José, Costa Rica", Latitud = 9.9359219, Longitud = -84.0919664 };
            Vertices.Insertar(nVer1);

            //10
            nVer1 = new Vertice { Nombre = "Cantón Heredia, Costa Rica", Latitud = 10.1773322, Longitud = -84.0590094 };
            Vertices.Insertar(nVer1);

            //11
            nVer1 = new Vertice { Nombre = "Cantón San Rafael, Costa Rica", Latitud = 10.0580387, Longitud = -84.0712921 };
            Vertices.Insertar(nVer1);

            //12
            nVer1 = new Vertice { Nombre = "Cantón Cartago, Costa Rica", Latitud = 9.7889864, Longitud = -83.9047616 };
            Vertices.Insertar(nVer1);

            //13
            nVer1 = new Vertice { Nombre = "Cantón Turrialba, Costa Rica", Latitud = 9.7811058, Longitud = -83.498266 };
            Vertices.Insertar(nVer1);

            //14
            nVer1 = new Vertice { Nombre = "Cantón Oreamuno, Costa Rica", Latitud = 9.9974653, Longitud = -83.8457032 };
            Vertices.Insertar(nVer1);

            //15
            nVer1 = new Vertice { Nombre = "Cantón Zarcero, Costa Rica", Latitud = 10.2185909, Longitud = -84.4066445 };
            Vertices.Insertar(nVer1);

            //16
            nVer1 = new Vertice { Nombre = "Cantón Liberia, Costa Rica", Latitud = 10.6927375, Longitud = -85.4987893 };
            Vertices.Insertar(nVer1);

            //19
            nVer1 = new Vertice { Nombre = "Cantón Nicoya, Costa Rica", Latitud = 10.1034154, Longitud = -85.4153082 };
            Vertices.Insertar(nVer1);

            //20
            nVer1 = new Vertice { Nombre = "Cantón Buenos Aires, Costa Rica", Latitud = 9.0825136, Longitud = -83.2465025 };
            Vertices.Insertar(nVer1);

            //21
            nVer1 = new Vertice { Nombre = "Provincia Limón, Cariari, 70205 Costa Rica", Latitud = 10.3628805, Longitud = -83.7354423 };
            Vertices.Insertar(nVer1);

            //22
            nVer1 = new Vertice { Nombre = "Provincia Limón, Guápiles, 70201 Costa Rica", Latitud = 10.2147844, Longitud = -83.786999 };
            Vertices.Insertar(nVer1);

            //23
            nVer1 = new Vertice { Nombre = "Provincia Puntarenas, Ciudad Cortés, 60501 Costa Rica", Latitud = 8.9630807, Longitud = -83.5238182 };
            Vertices.Insertar(nVer1);

            //24
            nVer1 = new Vertice { Nombre = "Zapotal, Cantón Carrillo, Costa Rica", Latitud = 10.505216682025221, Longitud = -85.7698069806843 };
            Vertices.Insertar(nVer1);

            //25
            nVer1 = new Vertice { Nombre = "Provincia Puntarenas, Mal País, 60111 Costa Rica", Latitud = 9.60228342770722, Longitud = -85.11706568145269 };
            Vertices.Insertar(nVer1);

            //26
            nVer1 = new Vertice { Nombre = "Provincia Puntarenas, Potrero Grande, 60303 Costa Rica", Latitud = 9.311472073463491, Longitud = -83.16131053758512 };
            Vertices.Insertar(nVer1);

            //27
            nVer1 = new Vertice { Nombre = "Calle Granados, Provincia Cartago, Cervantes, 30602 Costa Rica", Latitud = 9.897569949066408, Longitud = -83.82193442906934 };
            Vertices.Insertar(nVer1);
        }
    }
}
