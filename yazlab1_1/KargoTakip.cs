using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace yazlab1_1
{
    public partial class KargoTakip : Form
    {
        public static List<PointLatLng> pointList = new List<PointLatLng>();
        PointLatLng kargocu,merkez;
        string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;

        public KargoTakip()
        {
            InitializeComponent();
        }

        private void KargoTakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbCargoAppDataSet.kargo' table. You can move, or remove it, as needed.
            updateDataGridView();
            DataGridViewKargoProperty();
            GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            merkez = new PointLatLng(40.7682567230577, 29.9435806274414);
            kargocu = new PointLatLng(40.7682567230577, 29.9435806274415);
            pointList.Add(merkez);
            Login.g.AddMarker(merkez, GMarkerGoogleType.arrow);
            Login.g.AddMarker(kargocu, GMarkerGoogleType.yellow_dot);
        }

        public void updateDataGridView()
        {
            this.kargoTableAdapter.Fill(this.dbCargoAppDataSet.kargo);
        }

        private void btnDeleteCargo_Click(object sender, EventArgs e)
        {
            var kargoId = txtSelectedCargoInfo.Text;
            if (!String.IsNullOrEmpty(kargoId))
            {
                string plat = "a", plong = "a";
                using (var conn = new SqlConnection(connectionString))
                {
                    using (var command = conn.CreateCommand())
                    {
                        bool control = false;
                        conn.Open();
                        command.CommandText = @"select kargoId,kargoLokasyon from kargo where kargoId = @kargoId";
                        command.Parameters.AddWithValue("@kargoId", kargoId);
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var location = reader.GetString(1);
                                string[] withComma = location.Split(',');
                                plat = withComma[0];
                                plong = withComma[1];
                                control = true;
                            }
                        }
                        if (!control)
                        {
                            MessageBox.Show("Girilen kargo numarasına ait kargo bulunamamaktadır.");
                        }
                        else
                        {
                            using (var command2 = conn.CreateCommand())
                            {
                                command2.CommandText = @"delete from kargo where kargoId = @kargoId";
                                command2.Parameters.AddWithValue("@kargoId", kargoId);
                                command2.ExecuteNonQuery();
                            }

                            for (int i = 0; i < pointList.Count; i++)
                            {
                                if (pointList[i].Lat.ToString() == plat && pointList[i].Lng.ToString() == plong)
                                {
                                    pointList.RemoveAt(i);
                                }
                            }
                        }
                        conn.Close();
                    }
                }
                updateDataGridView();
                ShortestPathAlgorithm shortestPathAlgorithm = new ShortestPathAlgorithm();
                List<int> liste = shortestPathAlgorithm.shortestPath(pointList);
                Login.g.clearRoutes();
                Login.g.pointMarker();
                Login.g.drawRoute(liste);
                drawDeliverer();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek kargoyu seçiniz.");
            }

        }

        private void DataGridViewKargoProperty()
        {
            dataGridViewKargo.AllowUserToAddRows = false;
            dataGridViewKargo.Columns[0].HeaderText = "Id";
            dataGridViewKargo.Columns[1].HeaderText = "Müşteri Ad";
            dataGridViewKargo.Columns[2].HeaderText = "Lokasyon"; 
            dataGridViewKargo.Columns[2].Width = 200;
            dataGridViewKargo.Columns[3].HeaderText = "Teslim Durumu";
        }

        private void dataGridViewKargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = dataGridViewKargo.Rows[e.RowIndex].Cells[0].Value;
            txtSelectedCargoInfo.Text = value.ToString();
        }

        private void addCargoPoint_Click(object sender, EventArgs e)
        {
            var musteriAd = txtCustomerName.Text;
            if (!txtAddress.Text.Trim().Equals("") && !musteriAd.Trim().Equals(""))
            {
                GeoCoderStatusCode statusCode;
                var pointLatLng = GoogleMapProvider.Instance.GetPoint(txtAddress.Text.Trim(), out statusCode);
                if (statusCode == GeoCoderStatusCode.OK)
                {
                    var pt = pointLatLng ?? default(PointLatLng);
                    var location = pt.Lat.ToString() + "," + pt.Lng.ToString();

                    pointList.Add(pt);
                   
                    using (var conn = new SqlConnection(connectionString))
                    {
                        using (var command = conn.CreateCommand())
                        {
                            conn.Open();
                            command.CommandText = @"insert into kargo values(@musteriAd,@lokasyon,@teslim)";
                            command.Parameters.AddWithValue("@musteriAd", musteriAd);
                            command.Parameters.AddWithValue("@lokasyon", location);
                            command.Parameters.AddWithValue("@teslim", "Teslim Edilmedi");
                            command.ExecuteNonQuery();
                            conn.Close();
                        }
                    }
                    updateDataGridView();
                    ShortestPathAlgorithm shortestPathAlgorithm = new ShortestPathAlgorithm();
                    List<int> liste = shortestPathAlgorithm.shortestPath(pointList);

                    Login.g.clearRoutes();
                    Login.g.pointMarker();
                    Login.g.drawRoute(liste);
                    drawDeliverer();
                }
                else
                {
                    MessageBox.Show("Hatalı adres girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Adres ve müşteri alanlarını doldurunuz.");
            }
        }

        public void deliverCargo()
        {
            ShortestPathAlgorithm shortestPathAlgorithm = new ShortestPathAlgorithm();
            List<int> liste = shortestPathAlgorithm.shortestPath(pointList);

            if (liste.Count > 0)
            {
                kargocu.Lat = pointList[liste[0]].Lat;
                kargocu.Lng = pointList[liste[0]].Lng;
                pointList.RemoveAt(liste[0]);
                pointList[0] = kargocu;
                if(pointList[0].Lat == merkez.Lat && pointList[0].Lng == merkez.Lng)
                {
                    pointList.RemoveAt(0);
                }
                liste.RemoveAt(0);
            }

            Login.g.clearRoutes();
            string kargoLokasyon = kargocu.Lat + "," + kargocu.Lng;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = @"update kargo set kargoTeslim = 'Teslim Edildi' where kargoLokasyon = @kargoLokasyon";
                    command.Parameters.AddWithValue("@kargoLokasyon", kargoLokasyon);
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            updateDataGridView();
        }

        public void drawDeliverer()
        {
            Login.g.AddMarker(kargocu, GMarkerGoogleType.yellow_dot);
        }

        private void btnDeliverCargo_Click(object sender, EventArgs e)
        {
            deliverCargo();
            ShortestPathAlgorithm shortestPathAlgorithm = new ShortestPathAlgorithm();
            List<int> liste = shortestPathAlgorithm.shortestPath(pointList);
            Login.g.drawRoute(liste);
            Login.g.pointMarker();
            drawDeliverer();  
        }
    }
}
