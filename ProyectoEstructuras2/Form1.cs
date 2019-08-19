using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Logica.ControladorGrafo;
using Logica.LogicaGrafo;
using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoEstructuras2
{
    public partial class Form1 : Form
    {
        private ControladorGrafo GestorGrafo;
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;
        private readonly double InitialLat = 9.916915;
        private readonly double InitialLng = -84.096066;
        public Form1()
        {
            GestorGrafo = new ControladorGrafo();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(InitialLat, InitialLng);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;

            CargarVertices();
            CbOrigin_Charge();
            CblDestino_Charge();
            ////Marcador
            marker = new GMarkerGoogle(new PointLatLng(), GMarkerGoogleType.green_small);
            markerOverlay.Markers.Add(marker); //Se agrega marcador al mapa

            //tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", InitialLat, InitialLng);

            //Se agrega el mapa y el marcador al map controller
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void SetLocationOnMap(double lat, double lng)
        {
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        private string GetNearestLocationsFromVertice(Vertice vertice)
        {
            Vertice verticeCercano = null;
            GeoCoordinate coordenadasPrimerVertice = new GeoCoordinate(vertice.Latitud, vertice.Longitud);
            double lowestDistance = 9999999999;
            var verticesList = GestorGrafo.ObtenerVertices();
            foreach (Vertice vertice1 in verticesList)
            {
                Vertice temp = vertice1;
                while (temp != null)
                {
                    if (temp.Nombre.ToLower() != vertice.Nombre.ToLower())
                    {
                        GeoCoordinate c2 = new GeoCoordinate(temp.Latitud, temp.Longitud);
                        double distanceInKm = coordenadasPrimerVertice.GetDistanceTo(c2) / 1000;
                        if (distanceInKm < lowestDistance)
                        {
                            lowestDistance = distanceInKm;
                            verticeCercano = temp;
                        }
                    }
                    temp = temp.Siguiente;
                }
            }

            return vertice.Nombre + " está a " + Math.Round(lowestDistance, 2).ToString() + " km de " + verticeCercano.Nombre + ".";

        }

        /// <summary>
        /// Carga todos los vertices.
        /// </summary>
        private void CargarVertices()
        {
            markerOverlay = new GMapOverlay("Marcadores");
            var vertices = GestorGrafo.ObtenerVertices();

            foreach (var obj in vertices)
            {
                var nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
                var nMarker = new GMarkerGoogle(nPoint, GMarkerGoogleType.green_small);
                markerOverlay.Markers.Add(nMarker);

                nMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                nMarker.ToolTipText = string.Format(obj.Nombre);
            }
        }

        private void BtnTrazarGrafo_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }

        /// <summary>
        /// Obtiene los arcos para trazar la ruta del grafo
        /// </summary>
        private void ObtenerRuta()
        {
            var vertices = GestorGrafo.ObtenerVertices();

            foreach (var obj in vertices)
            {
                var origen = new PointLatLng(obj.Latitud, obj.Longitud);

                while (obj.Arcos.Cabeza != null)
                {
                    var destino = new PointLatLng(obj.Arcos.Cabeza.VerticeDestino.Latitud, obj.Arcos.Cabeza.VerticeDestino.Longitud);
                    obj.Arcos.Cabeza = obj.Arcos.Cabeza.Siguiente;
                    TrazarGrafo(origen, destino);
                }

            }

        }

        /// <summary>
        /// Traza los arcos en el grafo
        /// </summary>
        private void TrazarGrafo(PointLatLng origen, PointLatLng destino)
        {
            List<PointLatLng> direcciones = new List<PointLatLng>();
            direcciones.Add(origen);
            direcciones.Add(destino);

            GMapRoute r = new GMapRoute(direcciones, "routes");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routesOverlay);
            r.Stroke.Width = 2;
            r.Stroke.Color = Color.Coral;

        }

        private void CblOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblOrigen.Show();
        }

        /// <summary>
        /// Carga el nombre de las rutas en el dropdown de origen 
        /// </summary>
        private void CbOrigin_Charge()
        {
            var vertices = GestorGrafo.ObtenerVertices();
            foreach (var obj in vertices)
            {
                cblOrigen.Items.Add(obj.Nombre);
            }
            button1.Enabled = true;
        }

        private void CblDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            cblDestino.Show();
        }



        /// <summary>
        /// Carga el nombre de las rutas en el dropdown de destino 
        /// </summary>
        private void CblDestino_Charge()
        {
            var vertices = GestorGrafo.ObtenerVertices();
            foreach (var obj in vertices)
            {
                cblDestino.Items.Add(obj.Nombre);
            }
        }

        private void BtnIr_Click(object sender, EventArgs e)
        {
            gMapControl1.Overlays.Clear();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!cblOrigen.Text.Equals(""))
            {
                var key = cblOrigen.SelectedItem.ToString().ToLower();
                string feedbackMessage;

                if (!string.IsNullOrWhiteSpace(key))
                {
                    var nVertice = GestorGrafo.BuscarVertice(key);

                    if (nVertice != null)
                    {
                        feedbackMessage = "Las coordenadas de " + nVertice.Nombre + " son:\n " + nVertice.Latitud + ", " + nVertice.Longitud + ". " + "\n" + GetNearestLocationsFromVertice(nVertice);
                        SetLocationOnMap(nVertice.Latitud, nVertice.Longitud);
                    }
                    else
                    {
                        feedbackMessage = "Su busqueda no tuvo resultado.";
                    }
                }
                else
                {
                    feedbackMessage = "Ingrese un valor.";
                }

                MessageBox.Show(feedbackMessage, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se ha seleccionado vertice de origen", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnVerUbicacionAdyacentes_Click(object sender, EventArgs e)
        {
            if (!cblOrigen.Text.Equals(""))
            {
                var startPointKey = cblOrigen.SelectedItem.ToString().ToLower();

                if (!string.IsNullOrWhiteSpace(startPointKey))
                {
                    var startPoint = GestorGrafo.BuscarVertice(startPointKey);

                    if (startPoint != null)
                    {
                        MessageBox.Show(startPoint.Arcos.ToPrint(), "Puntos adyacentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el vertice buscado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese la ubicacion origen", "Advertencia", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado vertice de origen", "Advertencia", MessageBoxButtons.OK);
            }
        }

        private void BtnRutaMin_Click(object sender, EventArgs e)
        {
            var verticeOrigen = new Vertice();
            var verticeDestino = new Vertice();
            if (!cblOrigen.Text.Equals("") && !cblDestino.Text.Equals(""))
            {
                if (!cblOrigen.Text.Equals(cblDestino.Text))
                {
                    var vertices = GestorGrafo.ObtenerVertices();
                    foreach (var obj in vertices)
                    {
                        if (obj.Nombre.Equals(cblOrigen.Text))
                        {
                            verticeOrigen = obj;
                        }
                        if (obj.Nombre.Equals(cblDestino.Text))
                        {
                            verticeDestino = obj;
                        }
                    }

                    var listVertices = GestorGrafo.Shortest_path(verticeOrigen, verticeDestino);
                }
            }

        }

        private void Ruta(List<Vertice> list)
        {
            var destino = new PointLatLng();
            foreach (var obj in list)
            {
                var origen = new PointLatLng(obj.Latitud, obj.Longitud);

                if(destino == null)
                {
                    destino.Equals(origen);
                }
                else
                {
                    TrazarGrafo(origen, destino);
                    destino.Equals(origen);
                }
            }
        }
    }
}
