using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
using Clases;

namespace chevere_master
{
    public partial class frmTouristRouts : Form
    {
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private Conexion conexion = new Conexion();

        GMapOverlay routes;
        Bitmap bitmap = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap2 = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap3 = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap4 = (Bitmap)Image.FromFile("img/img3.jpg");
        TouristRouts grafo = new TouristRouts();

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            lbl_name.Text = item.ToolTipText;
            pictureBox1.Image = bitmap;
        }



        public frmTouristRouts()
        {
            InitializeComponent();
        }

        private void Info_rutas_Load(object sender, EventArgs e)
        {
            var markers = new GMapOverlay("markers");
            //configuración inicial 
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(13.9259486, -89.8411382);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 10;
            map.AutoScroll = true;
            Sites sitio = new Sites();
            List<PointLatLng> points = new List<PointLatLng>();
            //cargar todas las rutas en el mapa
            try
            {
                string sql = "select *  from sites where routesID = 1 order by id desc";
                //variables de conexion
                Conexion conexion = new Conexion();
                SqlDataAdapter dataAdapter;
                SqlDataReader dataReader;

                conexion.Conectar();
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        map.Position = new PointLatLng(Convert.ToDouble(dataReader["latitude"].ToString()), Convert.ToDouble(dataReader["longitude"].ToString()));
                        routes = new GMapOverlay("Ruta 1");
                        var marker1 = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(dataReader["latitude"].ToString()), Convert.ToDouble(dataReader["longitude"].ToString())), GMarkerGoogleType.arrow);
                        marker1.ToolTipMode = MarkerTooltipMode.Always;
                        marker1.ToolTipText = String.Format(dataReader["name"].ToString());

                        routes.Markers.Add(marker1);
                        map.Overlays.Add(routes);

                        //ahora agregamos  el mapa  y el marcador  al map control
                        points.Add(new PointLatLng(Convert.ToDouble(dataReader["latitude"].ToString()), Convert.ToDouble(dataReader["longitude"].ToString())));

                        //llenar los vertices del grafo
                        sitio.Id = (int)dataReader["id"];
                        sitio.Name = dataReader["name"].ToString();
                        sitio.Description = dataReader["descripcion"].ToString();
                        sitio.Assessment = (int)dataReader["assessment"];
                        sitio.Picture = dataReader["picture"].ToString();
                        sitio.Latitude = (float)dataReader["latitude"];
                        sitio.Longitude = (float)dataReader["longitude"];
                        sitio.Climate_id = (int)dataReader["climate_id"];
                        sitio.Category_id = (int)dataReader["category_id"];
                        sitio.Visitado = (int)dataReader["visitado"];
                        sitio.Etiqueta = (int)dataReader["etiqueta"];
                        grafo.AgregarSitio(sitio);
                    }

                    dataReader.Close();
                }
                else
                {
                    MessageBox.Show("No hay pedidos que mostrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataReader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar los sitios " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            GMapRoute routess = new GMapRoute(points, "Ruta Turística Las Flores")
            {
                Stroke = new Pen(Color.Green, 5)
            };
            routes.Routes.Add(routess);
            map.Overlays.Add(routes);

            txtdistancia.Text = routess.Distance + " km";

        }

    }
}
