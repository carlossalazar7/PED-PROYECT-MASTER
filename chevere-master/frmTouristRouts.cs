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
using FontAwesome.Sharp;
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
       
        GMapOverlay routes;
        Bitmap bitmap = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap2 = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap3 = (Bitmap)Image.FromFile("img/img3.jpg");
        Bitmap bitmap4 = (Bitmap)Image.FromFile("img/img3.jpg");
        TouristRouts grafo = new TouristRouts();
        CVertice vertice = new CVertice();
        Sites sitio = new Sites();
        Sites aux = new Sites();
        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            try
            {
                vertice = new CVertice();
                sitio = new Sites();
                aux = new Sites();
                lbl_name.Text = item.ToolTipText;
                pictureBox1.Image = bitmap;
               
                sitio.Name = item.ToolTipText;

                vertice.Valor = sitio;
                aux = grafo.BuscarVertice(sitio);
                if (aux != null)
                {

                    lbl_description.Text = aux.Description;
                }
                else
                {
                    MessageBox.Show("Vertice no Encontrado");
                }
            }
            catch(Exception ex)
            {

            }
        }
        public frmTouristRouts()
        {
            InitializeComponent();
            ini();
            actualizarGrid();
            cbx_Puntuación.SelectedIndex = 0;
            iniGrid();
        }
        private void Info_rutas_Load(object sender, EventArgs e)
        {
            iniGrid();
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
                string sql = "select * from sites where routesID = 1 order by id desc";
                //variables de conexion
                Conexion conexion = new Conexion();
                SqlDataAdapter dataAdapter;
                SqlDataReader dataReader; conexion.Conectar();
                dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
                dataReader = dataAdapter.SelectCommand.ExecuteReader();
                CVertice verticeAux = new CVertice();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        sitio = new Sites();
                        verticeAux = new CVertice();


                        map.Position = new PointLatLng(Convert.ToDouble(dataReader["latitude"].ToString()),
                            Convert.ToDouble(dataReader["longitude"].ToString()));
                        routes = new GMapOverlay("Ruta 1");
                        var marker1 = new GMarkerGoogle(
                            new PointLatLng(
                                Convert.ToDouble(dataReader["latitude"].ToString()),
                                Convert.ToDouble(dataReader["longitude"].ToString())
                            ), GMarkerGoogleType.arrow);
                        marker1.ToolTipMode = MarkerTooltipMode.Always;
                        marker1.ToolTipText = String.Format(dataReader["name"].ToString()); routes.Markers.Add(marker1);
                        map.Overlays.Add(routes); //ahora agregamos el mapa y el marcador al map control
                        points.Add(new PointLatLng(Convert.ToDouble(dataReader["latitude"].ToString()), Convert.ToDouble(dataReader["longitude"].ToString()))); //llenar los vertices del grafo
                        sitio.Id = (int)dataReader["id"];
                        sitio.Name = dataReader["name"].ToString();
                        sitio.Description = dataReader["description"].ToString();
                        sitio.Assessment = (int)dataReader["assessment"];
                        sitio.Picture = dataReader["picture"].ToString();
                        sitio.Latitude = float.Parse(dataReader["latitude"].ToString()); //Este genera error
                        sitio.Longitude = float.Parse(dataReader["longitude"].ToString());
                       
                        //insertar vertices en el grafo
                        grafo.AgregarSitio(sitio);
                        verticeAux.Valor = sitio;
                        grafo.AgregarVertice(verticeAux);
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
            map.Overlays.Add(routes); txtdistancia.Text = routess.Distance + " km";
        }
        private void label2_Click(object sender, EventArgs e)
        { }
        private void ini() //Inicializador de la ruta, muestra la primera ruta en pantalla
        {
              Conexion conexion = new Conexion();
        conexion.Conectar();
            string sql = "SELECT name,description,assessment FROM routes";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("mail", frmLogIn.user); adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt); lbl_name.Text = dt.Rows[0][0].ToString();
            lbl_description.Text = dt.Rows[0][1].ToString(); conexion.Cerrar();
        }
        private void btn_Comentar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();
            DialogResult f = MessageBox.Show("Seguro quieres comentar esto?", "Aviso", MessageBoxButtons.OKCancel); if (f == DialogResult.OK)
            {
                try
                {

                    conexion.Conectar();
                    string insertar;
                    insertar = "Insert INTO [dbo].[user_routes]([User_id],[Routes_id],[Comment],[assessment])";
                    insertar += "VALUES (@user_id, @Routes_id, @Comment, @assessment)";
                    SqlCommand InsertInto = new SqlCommand(insertar, conexion.Conn);
                    //Parametros para la inserción
                    InsertInto.Parameters.Add(new SqlParameter("@user_id", SqlDbType.Int));
                    InsertInto.Parameters["@user_id"].Value = getidUser();
                    InsertInto.Parameters.Add(new SqlParameter("@Routes_id", SqlDbType.Int));
                    InsertInto.Parameters["@Routes_id"].Value = 1;
                    InsertInto.Parameters.Add(new SqlParameter("@Comment", SqlDbType.VarChar, 255));
                    InsertInto.Parameters["@Comment"].Value = txb_Comentario.Text;
                    InsertInto.Parameters.Add(new SqlParameter("@assessment", SqlDbType.Int));
                    InsertInto.Parameters["@assessment"].Value = Convert.ToInt32(cbx_Puntuación.Text);
                    InsertInto.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Revise si sus datos son validos" + error + "", "Error", MessageBoxButtons.OK);
                }
                finally
                {
                    conexion.Cerrar();
                    txb_Comentario.Clear();
                    cbx_Puntuación.SelectedIndex = 0;
                    actualizarGrid();
                }
            }
        }
        private int getidUser()
        {
            Conexion conexion = new Conexion();
            string sql1 = "SELECT id FROM users WHERE email = @mail";
            command = new SqlCommand(sql1, conexion.Conn);
            command.Parameters.AddWithValue("@mail", frmLogIn.user);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit); int i = Convert.ToInt32(dit.Rows[0][0]); return i;
        }
        private void actualizarGrid()
        {
            Conexion conexion = new Conexion();
            SqlDataAdapter dataAdapter;
            SqlDataReader dataReader;

            conexion.Conectar(); 
            string sql = "SELECT U.first_name, UR.Comment, UR.assessment FROM user_routes UR INNER JOIN users U ON UR.User_id =U.id";
            dataAdapter = new SqlDataAdapter(sql, conexion.Conn);
            dataReader = dataAdapter.SelectCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    this.dgw_Comentarios.Rows.Add(
                        dataReader["first_name"].ToString(),
                        dataReader["Comment"].ToString(),
                        dataReader["assessment"].ToString());
                }
                dataReader.Close();
            }
            else
            {
                MessageBox.Show("No hay comentarios aun!, toma un minuto para comentar nuesta ruta");
            }
            conexion.Cerrar();
        }
        private void iniGrid()
        {
            Conexion conexion = new Conexion();

            conexion.Conectar();
            string sql = "SELECT * FROM user_routes";
            command = new SqlCommand(sql, conexion.Conn);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit); string sql1 = "SELECT COUNT(*) FROM user_routes";
            SqlCommand Count = new SqlCommand(sql1, conexion.Conn);
            SqlDataAdapter adaptCount = new SqlDataAdapter(Count);
            DataTable dc = new DataTable();
            adaptCount.Fill(dc);
            int f = Convert.ToInt32(dc.Rows[0][0]); for (int i = 0; i > 2; i++)
            {
                int n = dgw_Comentarios.Rows.Add(); dgw_Comentarios.Rows[i].Cells[0].Value = dit.Rows[i][0].ToString();
                dgw_Comentarios.Rows[i].Cells[1].Value = dit.Rows[i][1].ToString();
                dgw_Comentarios.Rows[i].Cells[2].Value = dit.Rows[i][2].ToString();
            }
            conexion.Cerrar();
        }
    }
}

