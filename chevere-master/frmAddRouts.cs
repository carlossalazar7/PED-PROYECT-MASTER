using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;



namespace chevere_master
{
    public partial class frmAddRouts : frmChildMenu_GUI
    {
        private List<PointLatLng> _points;
        public frmAddRouts()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }
        private void frmAddRouts_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;

        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            _points.Add( new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRout_Click(object sender, EventArgs e)
        {
            var route = GoogleMapProvider.Instance.GetRoute(_points[0],_points[1],true,false,14);
            var r = new GMapRoute(route.Points, "My Route");

            var routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            map.Overlays.Add(routes);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            map.Position = new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text));
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)), GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);



        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {

        }

    
    }
}
