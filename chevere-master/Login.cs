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
using System.Runtime.InteropServices;

namespace chevere_master
{
    public partial class Login : Form
    {
        //conexion bd
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private static Conexion conexion = new Conexion();

        ///Variable  ver la contraseña
        private bool ok;

        public Login()
        {
            InitializeComponent();
            ////Vefinimos falso ver la contrasenia
            ok = true;
        }


        private void InitializeMyControl()
        {
            txtPass.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            VerificarUsuario(this.txtUsuario.Text, this.txtPass.Text);
        }

        public void VerificarUsuario(string user, string password)
        {
            string sql = "SELECT u.id, u.first_name, u.last_name, r.name   FROM users " +
                    "u INNER JOIN roles r on  r.id = u.id_role  WHERE email = @usuario AND password= @contra";
            try
            {
                //abriendo conexion
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("usuario", user);
                command.Parameters.AddWithValue("contra", password);

                adapt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                //validar si devuelve un registro
                if (dt.Rows.Count == 1)
                {
                    this.Visible = false;
                    if (dt.Rows[0][3].ToString() == "Administrador")
                    {
                        //  User.Id = int.Parse(dt.Rows[0][2].ToString());
                        //  User.FirstName = dt.Rows[0][0].ToString();
                        //  MessageBox.Show($"nombre: {User.FirstName} id:{ User.Id } ");
                        new Home().Show();
                    }
                    else if (dt.Rows[0][3].ToString() == "Usuario")
                    {
                        MessageBox.Show("bienvenido cliente");
                        // User.Id = int.Parse(dt.Rows[0][2].ToString());
                        //  User.FirstName = dt.Rows[0][0].ToString();
                        //    new frmUsuarios().Show();
                        ///    MessageBox.Show($"nombre: {User.Nombre_de_Usuario} id:{ User.Id_Usuario} ");
                    }
                }
                else txtMessage.Text = "¡Usuario y/o contraseña incorrecta!";

            }
            catch (Exception ex)
            {
                txtMessage.Text = ex.Message;
            }
            finally
            {
                conexion.Cerrar();
            }
        }


        private void btnVerContrasenia_Click(object sender, EventArgs e)
        {
            if (ok)
            {
                txtPass.UseSystemPasswordChar = false;
                ok = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
                ok = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Reset().Show();
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CreateAccount().Show();
        }

        // procesimieto para movimiento de las ventanas

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lPararm);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
