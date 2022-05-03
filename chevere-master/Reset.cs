using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevere_master
{
    public partial class Reset : Form
    {
        //conexion bd
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private static Conexion conexion = new Conexion();

        public Reset()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string sql = "SELECT u.id, u.first_name, u.last_name, r.name   FROM users u INNER JOIN roles r on  r.id = u.id_role  WHERE email = @usuario";

                //abriendo conexion
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("usuario", txtCorreo.Text);

                adapt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                //validar si devuelve un registro
                if (dt.Rows.Count == 1)
                {
                    txtMessage.Text = "Ingresa tu nueva contraseña: ";
                    btnSavePassword.Visible = true;
                    txtPassword.Visible = true;
                    lblPassword.Visible = true;
                 }
                else
                {
                    txtMessage.Text = "Parece que no tienes cuenta, crea tu cuenta ahora";
                    btnCrearCuenta.Visible = true;
                }
            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message.ToString();
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FrmCreateAccount().Show();
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            new frmLogIn().Show();
        }
    }
}
