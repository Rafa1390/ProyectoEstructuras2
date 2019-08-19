using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuras2
{
    public class Calculador
    {
        public double CalculateKilometers(double startPointLat, double startPointLng, double endPointLat, double endPointLng)
        {
            var startPoint = new PointLatLng { Lat = startPointLat, Lng = startPointLng };
            var endPoint = new PointLatLng { Lat = endPointLat, Lng = endPointLng };
          //  var route = GoogleMapProvider.Instance.GetRoute(startPoint, endPoint, false, false, 14);
         //   var km = route.Distance;
            return 100;
        }
    }
}
