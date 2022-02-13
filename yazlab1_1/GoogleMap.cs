using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace yazlab1_1
{
    public partial class GoogleMap : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        GMapRoute r;
        public GMapOverlay routes;
        GMarkerGoogle marker;
        public GoogleMap()
        {
            InitializeComponent();
        }

        private void GoogleMap_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 11;
            map.SetPositionByKeywords("Kocaeli, Türkiye");
        }

        public void drawRoute(List<int> liste)    
        {
            for (int i=0; i<liste.Count; i++)  
            {
                if (i == 0)
                {
                    var route = GoogleMapProvider.Instance.GetRoute(KargoTakip.pointList[i], KargoTakip.pointList[liste[i]], false, false, 14);
                    r = new GMapRoute(route.Points, "My Route")
                    {
                        Stroke = new Pen(Color.Brown, 4)
                    };
                }
                else
                {
                    var route = GoogleMapProvider.Instance.GetRoute(KargoTakip.pointList[liste[i-1]], KargoTakip.pointList[liste[i]], false, false, 14);
                    r = new GMapRoute(route.Points, "My Route")
                    {
                        Stroke = new Pen(Color.Brown, 4)
                    };
                }
                routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                map.Overlays.Add(routes);
            }
        }
        
        public void clearRoutes()
        {
            if (map.Overlays.Count > 0)
            {
                map.Overlays.Clear();
                map.Refresh();
            }
            drawCenter();
            Login.k.drawDeliverer();
        }

        public void drawCenter()
        {
            PointLatLng merkez = new PointLatLng
            {
                Lat = 40.7682567230577,
                Lng = 29.9435806274414
            };
            AddMarker(merkez, GMarkerGoogleType.arrow);
        }
        
        public void pointMarker()
        {
            for(int i=0; i<KargoTakip.pointList.Count; i++)
            {
                AddMarker(KargoTakip.pointList[i]);
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                var location = point.Lat + "," + point.Lng;

                using (var conn = new SqlConnection(connectionString))
                {
                    using (var command = conn.CreateCommand())
                    {
                        conn.Open();
                        command.CommandText = @"insert into kargo values(@musteriAd,@lokasyon,@teslim)";
                        command.Parameters.AddWithValue("@musteriAd", "Ali");
                        command.Parameters.AddWithValue("@lokasyon", location);
                        command.Parameters.AddWithValue("@teslim", "Teslim Edilmedi");
                        command.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                Login.k.updateDataGridView();

                KargoTakip.pointList.Add(point);
                ShortestPathAlgorithm shortestPathAlgorithm = new ShortestPathAlgorithm();
                List<int> liste = shortestPathAlgorithm.shortestPath(KargoTakip.pointList);

                clearRoutes();
                pointMarker();
                drawRoute(liste);
                Login.k.drawDeliverer();
            }
        }

        public void LoadMap(PointLatLng point)
        {
            map.Position = point;
        }

        public void AddMarker(PointLatLng pointToAdd, GMarkerGoogleType markerType = GMarkerGoogleType.red_dot)
        {
            var markers = new GMapOverlay("markers");
            if(pointToAdd.Lat == 40.7682567230577 && pointToAdd.Lng == 29.9435806274414)
            {
                marker = new GMarkerGoogle(pointToAdd, GMarkerGoogleType.arrow);
            }
            else
            {
                marker = new GMarkerGoogle(pointToAdd, markerType);
            }

            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
        }
    }
}
