using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Logica.ControladorGrafo;
using System.Collections.Generic;
using System.Drawing;
using System.Collections;
using Logica.LogicaHash;
using Logica.LogicaGrafo;
using System.Device.Location;

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

        //Provisional -> Solo para obtener ubicaciones en el mapa, se puede borrar o reutilizar luego
        private void GMapControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;
            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
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
            foreach(Vertice vertice1 in verticesList)
            {
                Vertice temp = vertice1;
                while (temp != null)
                {
                    if(temp.Nombre.ToLower()  != vertice.Nombre.ToLower())
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
        /// Obtiene la ruta del grafo
        /// </summary>
        public void ObtenerRuta()
        {
            List<PointLatLng> direcciones;
            List<PointLatLng> otrasRutas;
            direcciones = new List<PointLatLng>();
            otrasRutas = new List<PointLatLng>(AgregarRutas());
            var vertices = GestorGrafo.ObtenerVertices();

            foreach (var obj in vertices)
            {
                var nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
                direcciones.Add(nPoint);
            }

            direcciones.AddRange(otrasRutas);
            GMapRoute r = new GMapRoute(direcciones, "routes");
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            routesOverlay.Routes.Add(r);
            gMapControl1.Overlays.Add(routesOverlay);
            r.Stroke.Width = 2;
            r.Stroke.Color = Color.Coral;
        }

        /// <summary>
        /// Agrega otras rutas para trazar en el mapa
        /// </summary>
        public List<PointLatLng> AgregarRutas()
        {
            List<PointLatLng> direcciones = new List<PointLatLng>();
            var vertices = GestorGrafo.ObtenerVertices();
            var obj = vertices[24];
            var nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
            direcciones.Add(nPoint);
            obj = vertices[19];
            nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
            direcciones.Add(nPoint);
            obj = vertices[4];
            nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
            direcciones.Add(nPoint);
            obj = vertices[1];
            nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
            direcciones.Add(nPoint);
            return direcciones;
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
            lblSearchOutput.Text = "";
            string input_value = txtSearch.Text.ToLower();
            if(input_value.Length > 0)
            {
                HashingTable table = GestorGrafo.ObtenerHashTable();
                var output = table.Get(input_value);
                if(output != null)
                {
                    Vertice vertice = (Vertice)output;
                    lblSearchOutput.Text = "Las coordenadas de " + vertice.Nombre + " son:\n " + vertice.Latitud + ", " + vertice.Longitud + ". " + "\n" + GetNearestLocationsFromVertice(vertice);
                    SetLocationOnMap(vertice.Latitud, vertice.Longitud);
                }
                else
                {
                    lblSearchOutput.Text = "Su busqueda no tuvo resultado.";
                }
            }
            else
            {
                lblSearchOutput.Text = "Ingrese un valor.";
            }
            txtSearch.Text = "";
        }

    }
}
