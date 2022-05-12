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
using Clases;
using System.Collections;
using System.Data.SqlClient;

namespace chevere_master
{
    public partial class frmAddRouts : frmChildMenu_GUI
    {
        private List<PointLatLng> _points;
        private TouristRouts grafo; //instanciamos la clase CGrafo
        private CVertice nuevoNodo;//instanciamos la clase CVertice
        private CVertice NodoOrigen;//instanciamos la clase CVertice
        private CVertice NodoDestino; //instanciamos la clase CVertice
        private int var_control = 0; //la utilizaremoa para determinar el estado de  la pizarra:
                                     //0 -> sin accion, 1-> dibujando arco, 2->Nuevo vértice
                                     //variables para el control de ventanas modales
                                     //private recorrido ventanaRecorrido //ventana para seleccionar el nodo inicial del recorrido


        List<CVertice> nodosRuta;
        List<CVertice> nodosOrdenados;
        bool buscarRuta = false, nuevoVertice = false, nuevoArco = false;
        bool profundidad = false, anchura = false, nodoEncontrado = false;
        Queue cola = new Queue();
        private Sites destino = new Sites(), origen = new Sites();
        private int distancia = 0;
        public string imagen;

        public frmAddRouts()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }
        private void frmAddRouts_Load(object sender, EventArgs e)
        {
            PointLatLng punto1 = new PointLatLng(13.9259486, -89.8411382);

            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = punto1;
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 10;
            map.AutoScroll = true;

            //proceso de cargar rutas automaticamente
            cargarDatos();
            load();

        }
        public void cargarDatos()
        {
            try
            {
                string sql = "select name, latitude, longitude from sites order by id desc";
                //variables de conexion
                Conexion conexion = new Conexion();
                SqlDataAdapter dataAdapter;
                SqlDataReader dataReader;
                SqlCommand command;

                conexion.Conectar();
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        this.tableSitios.Rows.Add(
                            dataReader["name"].ToString(),
                            dataReader["latitude"].ToString(),
                            dataReader["longitude"].ToString());
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
                MessageBox.Show("Error al mostrar los sitios " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            //Permite abrir el explorador de windows para que el usuario pueda elegir una imagen
            //Solo se ejecutara si el usuario ha seleccionado una imagen
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Se guarda la direccion de la imagen
                imagen = openFileDialog1.FileName;
                pictureBox10.Image = Image.FromFile(imagen);
            }
        }



        private void btnAddPoint_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();//crear un número random
            int id = rnd.Next(1, 10000);
            int assesment = rnd.Next(1, 6);

            //variables de conexion
            Conexion conexion = new Conexion();
            SqlCommand command;

            grafo = new TouristRouts();

            Sites sitio = new Sites();
            sitio.Id = id;
            sitio.Name = txtnombre.Text;
            sitio.Description = txtDescripcion.Text;
            sitio.Climate_id = cmbclima.SelectedIndex;
            sitio.Category_id = cmbcategoria.SelectedIndex;
            sitio.Assessment = assesment;
            sitio.Visitado = 0;

            _points.Add(new PointLatLng(Convert.ToDouble(txtLat.Text), Convert.ToDouble(txtLong.Text)));

            //proceso de inserción en la  base de datos
            bool creado = false;

            string sql = "INSERT INTO sites (name, description, assessment, picture, latitude, longitude, climate_id, " +
                "category_id , visitado, etiqueta, tree_root, routesID) VALUES  (@name, @descripcion, @assesment, " +
                "@picture, @latitude, @longitude, @climate_id, @category_id, @visitado, @etiqueta, @tree_root, @route_id)";

            try
            {
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("@name", txtnombre.Text);
                command.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                command.Parameters.AddWithValue("@assesment", assesment);
                command.Parameters.AddWithValue("@picture", imagen);
                command.Parameters.AddWithValue("@latitude", Convert.ToDouble(txtLat.Text));
                command.Parameters.AddWithValue("@longitude", Convert.ToDouble(txtLong.Text));
                command.Parameters.AddWithValue("@climate_id", 1);
                command.Parameters.AddWithValue("@category_id", 1);
                command.Parameters.AddWithValue("@visitado", 0);
                command.Parameters.AddWithValue("@etiqueta", 0);
                command.Parameters.AddWithValue("@tree_root", 1);
                command.Parameters.AddWithValue("@route_id", 1);
                creado = command.ExecuteNonQuery() > 0 ? true : false;

                //proceso de llenar la tabla
                tableSitios.Rows.Add(command.ExecuteScalar());
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al crear pedido en la DB: " + err.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _points.Clear();
        }

        private void btnGetRout_Click(object sender, EventArgs e)
        {



            var route = GoogleMapProvider.Instance.GetRoute(_points[0], _points[1], true, false, 14);
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

            load();
        }
        public void load()
        {
            var markers = new GMapOverlay("markers");
            //cargar todas las rutas en el mapa
            try
            {
                string sql = "select name, latitude, longitude from sites order by id desc";
                //variables de conexion
                Conexion conexion = new Conexion();
                SqlDataAdapter dataAdapter;
                SqlDataReader dataReader;
                SqlCommand command;

                conexion.Conectar();
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        map.Position = new PointLatLng(
                            Convert.ToDouble(dataReader["latitude"].ToString()),
                            Convert.ToDouble(dataReader["longitude"].ToString())
                            );
                        var markers1 = new GMapOverlay("markers");
                        var marker1 = new GMarkerGoogle(new PointLatLng(
                            Convert.ToDouble(dataReader["latitude"].ToString()),
                            Convert.ToDouble(dataReader["longitude"].ToString())
                            ),
                            GMarkerGoogleType.arrow);
                        markers.Markers.Add(marker1);
                        map.Overlays.Add(markers);
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
                MessageBox.Show("Error al mostrar los sitios " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
