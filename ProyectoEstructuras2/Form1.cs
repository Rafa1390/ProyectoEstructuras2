using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Logica.ControladorGrafo;

namespace ProyectoEstructuras2
{
    public partial class Form1 : Form
    {
        private ControladorGrafo GestorGrafo;
        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;

        private readonly double InitialLat = 10.0000000;
        private readonly double InitialLng = -84.0000000;

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
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            CargarVertices();

            ////Marcador
            marker = new GMarkerGoogle(new PointLatLng(InitialLat, InitialLng), GMarkerGoogleType.green);
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

            txtLatitud.Text = lat.ToString();
            txtLongitud.Text = lng.ToString();

            marker.Position = new PointLatLng(lat, lng);
            marker.ToolTipText = string.Format("Ubicación: \n Latitud: {0} \n Longitud: {1}", lat, lng);
        }

        /// <summary>
        /// Carga todos los vertices.
        /// </summary>
        private void CargarVertices()
        {
            markerOverlay = new GMapOverlay("Marcadores");
            var vertices = GestorGrafo.ObtenerVertices();
            
            foreach(var obj in vertices)
            {
                var nPoint = new PointLatLng(obj.Latitud, obj.Longitud);
                var nMarker = new GMarkerGoogle(nPoint, GMarkerGoogleType.green_small);
                markerOverlay.Markers.Add(nMarker);

                nMarker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                nMarker.ToolTipText = string.Format("Ubicación: \n Nombre: {0} \n Latitud: {1} \n Longitud: {2}", obj.Nombre, obj.Latitud, obj.Longitud);
            }
        }
    }
}
