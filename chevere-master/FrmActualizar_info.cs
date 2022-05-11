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

namespace chevere_master
{
    public partial class FrmActualizar_info : Form
    {
        User usuario = new User();
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private Conexion conexion = new Conexion();
        public FrmActualizar_info()
        {
            InitializeComponent();
            ini();
        }


        public void verificar()
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if (txb_ContraseñaNueva.TextLength >= 6 && txb_UsuarioNuevo.TextLength>=5 && txb_ApellidoNuevo.TextLength >=5)
            {
                usuario.FirstName = txb_UsuarioNuevo.Text;
                usuario.Password = txb_ContraseñaNueva.Text;
                usuario.LastName = txb_ApellidoNuevo.Text;
                alter();
                ini();
                MessageBox.Show("Se ha actualizado con exito");
            }
            else
            {
                MessageBox.Show("Ingresar datos validos: Contraseña de al menos 6 caracteres, nombre y apellidos de al menos 5 letras");
            }
            
        }

        private void ini()
        {
            conexion.Conectar();
            string sql = "select first_name, last_name, password, email FROM users WHERE email=@mail";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("@mail", frmLogIn.user);

            adapt = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapt.Fill(dt);

            lbl_Nombres.Text = dt.Rows[0][0].ToString();
            lbl_Apellidos.Text = dt.Rows[0][1].ToString();
            lbl_ContraseñaActual.Text = dt.Rows[0][2].ToString();
            lbl_Correo.Text = dt.Rows[0][3].ToString();
            txb_ApellidoNuevo.Text = dt.Rows[0][1].ToString();
            txb_UsuarioNuevo.Text = dt.Rows[0][0].ToString();
            txb_ContraseñaNueva.Text = dt.Rows[0][2].ToString();

            conexion.Cerrar();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void alter()
        {
            conexion.Conectar();
            string sql = "UPDATE users SET first_name=@first_name, password=@pass, last_name=@lastN WHERE email=@mail";
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("mail", frmLogIn.user);
            command.Parameters.AddWithValue("first_name", usuario.FirstName);
            command.Parameters.AddWithValue("pass", usuario.Password);
            command.Parameters.AddWithValue("lastN", usuario.LastName);
            command.ExecuteNonQuery();
            conexion.Cerrar();
        }
    }
}
