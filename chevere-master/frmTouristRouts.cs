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

namespace chevere_master
{
    public partial class frmTouristRouts : Form
    {
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private Conexion conexion = new Conexion();

        GMarkerGoogle marker, marker2, marker3, marker4, marker5, marker6, marker7;
        GMapOverlay routes;

        

        //Bitmap bitmap = (Bitmap)Image.FromFile("img/img3.jpg");

        PointLatLng
            punto1 = new PointLatLng(13.9259486, -89.8411382),
            punto2 = new PointLatLng(13.8683828, -89.8584498),
            punto3 = new PointLatLng(13.8626493, -89.8103242),
            punto4 = new PointLatLng(13.8431922, -89.7535668),
            punto5 = new PointLatLng(13.8302042, -89.7591162), 
            punto6 = new PointLatLng(13.7896338, -89.7638154),
            punto7 = new PointLatLng(13.7804785, -89.7474662);

        private void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
           lbl_name.Text= item.ToolTipText;
            //pictureBox1.Image = bitmap;
        }

        

        public frmTouristRouts()
        {
            InitializeComponent();
            ini();
            cbx_Puntuación.SelectedIndex = 0;
            iniGrid();
        }

        private void Info_rutas_Load(object sender, EventArgs e)
        {
            //configuración inicial 
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = punto1;
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 10;
            map.AutoScroll = true;

            //marcadores
          

            routes = new GMapOverlay("Ruta 1");
            marker = new GMarkerGoogle(punto1, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker); //agregamos al mapa

            marker2 = new GMarkerGoogle(punto2, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker2);

            marker3 = new GMarkerGoogle(punto3, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker3);

            marker4 = new GMarkerGoogle(punto4, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker4);

            marker5 = new GMarkerGoogle(punto5, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker5);

            marker6 = new GMarkerGoogle(punto6, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker6);

            marker7 = new GMarkerGoogle(punto7, GMarkerGoogleType.red_pushpin);
            routes.Markers.Add(marker7);


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
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(punto1);
            points.Add(punto2);
            points.Add(punto3);
            points.Add(punto4);
            points.Add(punto5);
            points.Add(punto6);
            points.Add(punto7);

            GMapRoute routess = new GMapRoute(points, "Ruta Turística Las Flores")
            {
                Stroke = new Pen(Color.Green, 5)
            };
            routes.Routes.Add(routess);
            map.Overlays.Add(routes);

            txtdistancia.Text = routess.Distance + " km";

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ini() //Inicializador de la ruta, muestra la primera ruta en pantalla
        {
            conexion.Conectar();
            string sql = "SELECT name,description,assessment FROM routes";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("mail", frmLogIn.user);

            adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            lbl_name.Text = dt.Rows[0][0].ToString();
            lbl_description.Text = dt.Rows[0][1].ToString();

            conexion.Cerrar();

        }

        private void btn_Comentar_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Seguro quieres comentar esto?", "Aviso", MessageBoxButtons.OKCancel);

            if (f == DialogResult.OK)
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
                catch(Exception error)
                {
                    MessageBox.Show("Revise si sus datos son validos" +error+"" ,"Error",MessageBoxButtons.OK);
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
            
            string sql1 = "SELECT id FROM users WHERE email = @mail";
            command = new SqlCommand(sql1, conexion.Conn);
            command.Parameters.AddWithValue("@mail", frmLogIn.user);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit);

            int i = Convert.ToInt32(dit.Rows[0][0]);
            

            return i;
        }

        private void actualizarGrid()
        {
            conexion.Conectar();

            string sql = "SELECT U.first_name, UR.Comment, UR.assessment FROM user_routes UR INNER JOIN users U ON UR.User_id =U.id WHERE U.email = @mail";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("@mail", frmLogIn.user);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit);
                

                int n = dgw_Comentarios.Rows.Add();

                dgw_Comentarios.Rows[n].Cells[0].Value = dit.Rows[0][0].ToString();
                dgw_Comentarios.Rows[n].Cells[1].Value = dit.Rows[0][1].ToString();
                dgw_Comentarios.Rows[n].Cells[2].Value = dit.Rows[0][2].ToString();


            conexion.Cerrar();
        }

        private void iniGrid()
        {
            conexion.Conectar();
            string sql = "SELECT * FROM user_routes";
            command = new SqlCommand(sql, conexion.Conn);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit);

            string sql1 = "SELECT COUNT(*) FROM user_routes";
            SqlCommand Count = new SqlCommand(sql1, conexion.Conn);
            SqlDataAdapter adaptCount = new SqlDataAdapter(Count);
            DataTable dc = new DataTable();
            adaptCount.Fill(dc);


            int f = Convert.ToInt32(dc.Rows[0][0]);

            for(int i=0; i > 2; i++)
            {
                int n = dgw_Comentarios.Rows.Add();

                dgw_Comentarios.Rows[i].Cells[0].Value = dit.Rows[i][0].ToString();
                dgw_Comentarios.Rows[i].Cells[1].Value = dit.Rows[i][1].ToString();
                dgw_Comentarios.Rows[i].Cells[2].Value = dit.Rows[i][2].ToString();
            }



            conexion.Cerrar();
        }
    }
}
