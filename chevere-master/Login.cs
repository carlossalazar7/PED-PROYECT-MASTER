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
    public partial class Login : Form
    {
        //conexion bd
        private SqlConnection connec;
        private SqlCommand command;
        private SqlDataAdapter adapt;
        private string cadenaconn;

        ///Variable  ver la contraseña
        private bool ok;

        public Login()
        {
            InitializeComponent();
            ////Vefinimos falso ver la contrasenia
            ok = true;

            //abriendo conexion
            Conexion conexion = new Conexion();
            conexion.conec();

            cadenaconn = conexion.cadena;

            connec = new SqlConnection(cadenaconn);
        }


        private void InitializeMyControl()
        {
            txtPass.PasswordChar = '*';
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            VerificarUsuario(this.txtUsuario.Text, this.txtPass.Text);
        }

        public void VerificarUsuario(string usuario, string contraseña)
        {
            try
            {
                connec.Open();
                command = new SqlCommand("SELECT u.id, u.first_name, u.last_name, r.name   FROM users " +
                    "u INNER JOIN roles r on  r.id = u.id_role  WHERE email = @usuario AND password= @contra", connec);

                command.Parameters.AddWithValue("usuario", usuario);
                command.Parameters.AddWithValue("contra", contraseña);

                adapt = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                //validar si devuelve un registro
                if (dt.Rows.Count == 1)
                {
                    this.Visible = false;
                    if (dt.Rows[0][3].ToString() == "Administrador")
                    {
                        MessageBox.Show("bienvenido admin");
                      //  User.Id = int.Parse(dt.Rows[0][2].ToString());
                      //  User.FirstName = dt.Rows[0][0].ToString();
                      //  MessageBox.Show($"nombre: {User.FirstName} id:{ User.Id } ");
                      //  new frmAdmin().Show();
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
                else
                {
                    MessageBox.Show("¡Usuario y/o contraseña incorrecta!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR");
            }
            finally
            {
                connec.Close();
            }
        }
    }
}
