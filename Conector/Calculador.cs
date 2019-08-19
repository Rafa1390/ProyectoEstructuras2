using System.Device.Location;

namespace ProyectoEstructuras2
{
    public class Calculador
    {
        public double CalculateKilometers(double startPointLat, double startPointLng, double endPointLat, double endPointLng)
        {
            var geoStartPoint = new GeoCoordinate(startPointLat, startPointLng);
            var geoEndPoint = new GeoCoordinate(endPointLat, endPointLng);
            var distanceKm = geoStartPoint.GetDistanceTo(geoEndPoint) / 1000;
            return distanceKm;
        }
    }
}
