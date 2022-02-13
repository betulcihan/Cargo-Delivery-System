using GMap.NET;
using GMap.NET.MapProviders;


namespace yazlab1_1
{
    class Distance
    {
        public double getDistance(PointLatLng point1, PointLatLng point2)
        {
            var route = GoogleMapProvider.Instance.GetRoute(point1, point2, false, false, 14);
            return route.Distance;
        }
    }
}
