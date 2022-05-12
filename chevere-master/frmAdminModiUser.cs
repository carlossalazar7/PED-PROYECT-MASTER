using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace chevere_master
{
    public partial class frmAdminModiUser : frmChildMenu_GUI
    {

        //Conexion a la base de Datooos 7u7 
        //private SqlConnection conn;
        //private SqlCommand query;
        //private Conexion conexion = new Conexion();
        //Variable ver la contra
        private bool okay;
        //Indice de busqueda
        private int index = -1;
        private int CountryCode = 0;

        public frmAdminModiUser()
        {
            InitializeComponent();
            //Desactivar botones del panel de operaciones
            btnCancelar.Visible = false;
            btnguardar.Visible = false;
            gpUser.Enabled = false;
            //Desactivando paneles de opciones
            pnlOpciones.Enabled = false;
            //Tabla de usuarios
            CargarUsuarios();
            //Se define como false ver la contra va para no ser meque.
            okay = true;

        }

        private void CargarUsuarios()
        {
            SqlConnection conn;
            SqlCommand query;
            Conexion conexion = new Conexion();

            try
            {
                //Inicializando la conexion
                conexion.Conectar();
                conn = conexion.Conn;

                //CargarUsuarios
                dgvUsuarios.DataSource = null;
                string Queryy7u7;
                Queryy7u7 = "select(last_name)from users";
                query = new SqlCommand(Queryy7u7, conn);
                SqlDataAdapter theDataMyBoy7U7 = new SqlDataAdapter(query);
                DataTable usersS = new DataTable();
                theDataMyBoy7U7.Fill(usersS);
                dgvUsuarios.DataSource = usersS;
            }
            catch (Exception error)
            {
                MessageBox.Show($"This is the error : {error} ");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtname.Clear();
            txtpassword.Clear();
            txtPasswordConfirmed.Clear();
            txtemail.Clear();
            cmbDocument.Text = "";
            cmb_Country.Text = "";
            cmb_departamento.Text = "";
            mtbnit.Clear();
   
            rbtAdmin.Checked = false;
            rbtTurista.Checked = false;
            rbtn_Masculino.Checked = false;
            rbtn_Femenino.Checked = false;

        }

        private void BuscarUsuario()
        {
            SqlConnection conn;
            SqlCommand query;
            Conexion conexion = new Conexion();

            string user = txtFiltUsar.Text.Trim();
            if (!(user == ""))
            {
                try
                {
                    //Inicializando la conexion
                    conexion.Conectar();
                    conn = conexion.Conn;

                    string consulta;
                    consulta = $"Select(last_name)from users where last_name like LOWER('%{user}%')";
                    query = new SqlCommand(consulta, conn);
                    SqlDataAdapter data = new SqlDataAdapter(query);
                    DataTable usersS = new DataTable();
                    data.Fill(usersS);
                    dgvUsuarios.DataSource = usersS;
                }
                catch (Exception error)
                {
                    MessageBox.Show($"This is the error : {error.Message} ");
                }
                finally
                {
                    conexion.Cerrar();
                }
            }
            else
            {
                CargarUsuarios();
            }
        }

        private void txtFiltUsar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarUsuario();

        }

        private void dgvUsuarios_DoubleClick(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand query;
            Conexion conexion = new Conexion();

            try
            {
                //Inicializando la conexion
                conexion.Conectar();
                conn = conexion.Conn;

                //Seleccionamos el nombre del usuario para su busqueda
                string user;
                DataGridViewRow seleccion = dgvUsuarios.SelectedRows[0];
                index = dgvUsuarios.Rows.IndexOf(seleccion);
                user = (string)dgvUsuarios.Rows[index].Cells[0].Value;
                //Consulta a la base de datos de seleccion
                string Queryy;
                Queryy = $"select (first_name + last_name), password, email, nit, dui, dirrection, country_id, birth_date, gender, id_role, id" +
                         $" from users where last_name = '{user}' ";
                query = new SqlCommand(Queryy, conn);
                SqlDataAdapter data = new SqlDataAdapter(query);
                DataTable usersS = new DataTable();
                data.Fill(usersS);

                //Asignando informacion
                //TextBox
                txtId.Text = usersS.Rows[0][10].ToString();
                txtname.Text = usersS.Rows[0][0].ToString();
                txtemail.Text = usersS.Rows[0][2].ToString();
                txtpassword.Text = usersS.Rows[0][1].ToString();
                txtPasswordConfirmed.Text = usersS.Rows[0][1].ToString();
                //RadioButtons
                if (usersS.Rows[0][8].ToString() == "M")
                {
                    rbtn_Masculino.Checked = true;
                }
                else
                {
                    rbtn_Femenino.Checked = true;
                }
                if ((int)usersS.Rows[0][9] == 1)
                {
                    rbtAdmin.Checked = true;
                }
                else
                {
                    rbtTurista.Checked = true;
                }
                //ComboBox
                
                cmb_departamento.Text = usersS.Rows[0][5].ToString();
                if (usersS.Rows[0][3].ToString() != "")
                {
                    cmbDocument.Text = "DUI";
                    mtbnit.Text = usersS.Rows[0][3].ToString();
                }
                else
                {
                    cmbDocument.Text = "NIT";
                    mtbnit.Text = usersS.Rows[0][3].ToString();
                }
                CountryCode = (int)usersS.Rows[0][6];
                switch ((int)usersS.Rows[0][6])
                {
                     
                    case 1:
                        cmb_Country.Text = "El Salvador";
                        
                        break;
                    case 2:
                        cmb_Country.Text = "España";
                        break;
                    case 3:
                        cmb_Country.Text = "Costa Rica";
                        break;
                    case 4:
                        cmb_Country.Text = "Panama";
                        break;
                    case 5:
                        cmb_Country.Text = "Guatemala";
                        break;
                    case 6:
                        cmb_Country.Text = "Honduras";
                        break;
                    case 7:
                        cmb_Country.Text = "Puesto Rico";
                        break;
                    case 8:
                        cmb_Country.Text = "Argentina";
                        break;
                    case 9:
                        cmb_Country.Text = "Nicaragua";
                        break;
                    case 10:
                        cmb_Country.Text = "Colombia";
                        break;
                    default:
                        break;
                }
                
                //Activacion de opciones
                pnlOpciones.Enabled = true;

            }
            catch (Exception error)
            {
                MessageBox.Show($"This is the error : {error.Message} ");

            }
            finally
            {
                conexion.Cerrar();
                
            }

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
   

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            if (okay)
            {
                btn_Ver.IconColor = Color.FromArgb(218, 0, 19);
                txtpassword.UseSystemPasswordChar = false;
                txtPasswordConfirmed.UseSystemPasswordChar = false;
                okay = false;
            }
            else
            {
                btn_Ver.IconColor = Color.FromArgb(14, 82, 165);
                txtpassword.UseSystemPasswordChar = true;
                txtPasswordConfirmed.UseSystemPasswordChar = true;
                okay = true;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ///Descativar botones del panel operaciones 
            gpUser.Enabled = true;
            btnCancelar.Visible = true;
            btnguardar.Visible = true;
            btnModify.Visible = false;
            gbUserName.Enabled = false;
            gbLista.Enabled = false;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            gpUser.Enabled = false;
            gbUserName.Enabled = true;
            gbLista.Enabled = true;
            ///Descativar botones del panel operaciones 
            btnCancelar.Visible = false;
            btnguardar.Visible = false;
            btnModify.Visible = true;
            //Desactivando panel de opciones;
            pnlOpciones.Enabled = false;
            LimpiarCampos();
        }


        private void btnguardar_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand query;
            Conexion conexion = new Conexion();

            ///Variables
            int usertype;
            string gendertype;

            if (rbtAdmin.Checked) usertype = 1;
            else usertype = 2;

            if (rbtn_Masculino.Checked) gendertype = "M";
            else gendertype = "F";


            if (txtpassword.Text.Trim() == txtPasswordConfirmed.Text.Trim())
            {
                int flag = 0;
                string user;
                DataGridViewRow seleccion = dgvUsuarios.SelectedRows[0];
                index = dgvUsuarios.Rows.IndexOf(seleccion);
                user = (string)dgvUsuarios.Rows[index].Cells[0].Value;

                try
                {
                    //Inicializando la conexion
                    conexion.Conectar();
                    conn = conexion.Conn;

                    string cadena = $"update users set " +
                        $" first_name = '{txtname.Text}', last_name ='{user}', password = '{txtpassword.Text}', email = '{txtemail.Text}',  nit= '{mtbnit.Text}', dirrection = '{cmb_departamento.Text}', country_id = '{CountryCode}',  id_role ='{usertype}', gender = '{gendertype}' where id = {int.Parse(txtId.Text)}";
                    query = new SqlCommand(cadena, conn);
                    flag = query.ExecuteNonQuery();
                    CargarUsuarios();
                    if (flag == 1)
                    {
                        MessageBox.Show("Se realizaron las modificaciones del usuario");
                        LimpiarCampos();
                        CargarUsuarios();
                        btnCancelar.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("No se completaron las modificaciones del usuario");
                    }
                    CargarUsuarios();
                    btnCancelar.PerformClick();
                }
                catch (Exception error)
                {
               
                }
                finally
                {
                    conexion.Cerrar();
                }
            }
            else
            {
                MessageBox.Show("La contraseña no coincide, vuelva a intentarlo", "Verificar");
            }
        }

    }

     
}
