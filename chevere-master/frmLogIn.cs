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
    public partial class frmLogIn : frmExternalGUI
    {
        //conexion bd
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private Conexion conexion = new Conexion();
        public static string user, password;

        //Forms
        FrmCreateAccount frmCreatAcc;

        ///Variable  ver la contraseña
        private bool ok;

        public frmLogIn()
        {
            InitializeComponent();
            ////Definimos falso ver la contrasenia
            ok = true;
        }


        private void InitializeMyControl()
        {
            txtPass.PasswordChar = '*';
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
                        new frmMenu_GUI().Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][3].ToString() == "Usuario")
                    {
                        MessageBox.Show("bienvenido cliente");
                        new FrmMenuUsuario().Show();
                        this.Hide();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreatAcc = new FrmCreateAccount();
            frmCreatAcc.Show();
            this.Hide();
        }

        private void linklblPassBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Reset().Show();
            this.Hide();
        }

        private new void btnSiguiente_Click(object sender, EventArgs e)
        {
            VerificarUsuario(this.txtUsuario.Text, this.txtPass.Text);
            user = txtUsuario.Text;
            password = txtPass.Text;

        }



    
    }
}
