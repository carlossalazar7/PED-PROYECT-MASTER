using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace chevere_master
{
    public partial class Info_rutas : Form
    {
        GMarkerGoogle marker, marker2, marker3, marker4, marker5, marker6, marker7;
        GMapOverlay markerOverlay;

        double LatInicial = 13.9259486;
        double LongInicial = -89.8411382;

        public Info_rutas()
        {
            InitializeComponent();
        }

        private void Info_rutas_Load(object sender, EventArgs e)
        {
            //configuración inicial 
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LongInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 10;
            gMapControl1.AutoScroll = true;

            //marcadores
            markerOverlay = new GMapOverlay("Ahuachapán");
            marker = new GMarkerGoogle(new PointLatLng(13.9259486, -89.8411382), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker); //agregamos al mapa

            marker2 = new GMarkerGoogle(new PointLatLng(13.8683828, -89.8584498), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker2);

            marker3 = new GMarkerGoogle(new PointLatLng(13.8626493, -89.8103242), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker3);

            marker4 = new GMarkerGoogle(new PointLatLng(13.9259486, -89.8411382), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker4);

            marker5 = new GMarkerGoogle(new PointLatLng(13.8302042, -89.7591162), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker5);

            marker6 = new GMarkerGoogle(new PointLatLng(13.7896338, -89.7638154), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker6);

            marker7 = new GMarkerGoogle(new PointLatLng(13.9259486, -89.7474662), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker7);


            //agregamos un tooltip  de tipo texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ahuachapan");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker2.ToolTipMode = MarkerTooltipMode.Always;
            marker2.ToolTipText = String.Format("Concepción de Ataco");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker3.ToolTipMode = MarkerTooltipMode.Always;
            marker3.ToolTipText = String.Format("Apanhecat");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker4.ToolTipMode = MarkerTooltipMode.Always;
            marker4.ToolTipText = String.Format("Juayúa");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker5.ToolTipMode = MarkerTooltipMode.Always;
            marker5.ToolTipText = String.Format("Salcoatitán");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker6.ToolTipMode = MarkerTooltipMode.Always;
            marker6.ToolTipText = String.Format("Santa Catarina Masahuat");

            //agregamos un tooltip  de tipo texto a los marcadores
            marker7.ToolTipMode = MarkerTooltipMode.Always;
            marker7.ToolTipText = String.Format("Nahuizalco");

            //ahora agregamos  el mapa  y el marcador  al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
