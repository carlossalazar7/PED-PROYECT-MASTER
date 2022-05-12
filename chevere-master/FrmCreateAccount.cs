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
using System.Net.Mail;

namespace chevere_master
{
    public partial class FrmCreateAccount : frmExternalGUI
    {
        //conexion bd
        private static Conexion conexion = new Conexion();
        private SqlCommand command;
        private SqlDataAdapter adapt;
        string p; //Almacena el nombre de el pais
        char g; //Almacena la letra de el genero
        int id = 1; // Almacena el id de la nacionalidad
        //Variables a usar
        private string PersonalDoc;

        public FrmCreateAccount()
        {
            InitializeComponent();
            ini();
        }


        private string PersonalInfo(string InfoCompara) 
        {
            if (cmbDocument.Text == InfoCompara) return mtbnit.Text;
            else return " ";

        }

        //Para regresar a login.
        private void label3_Click(object sender, EventArgs e)
        {
            frmLogIn Goback = new frmLogIn();
            Goback.Show();
            this.Close();
        }

        //Para mostrar la mascara correcta dependiendo del documento a proporcionar
        private void comboBox1_Leave(object sender, EventArgs e)
        {
            bool check = true;
            switch (cmbDocument.Text)
            {
                
                case "DUI":
                    mtbnit.Mask = "00000000-0";
                    CheckMissInfo(mtbnit, check);
                    PersonalDoc = cmbDocument.Text;
                    break;
                case "NIT":
                    mtbnit.Mask = "0000-000000-000-0";
                    CheckMissInfo(mtbnit, check);
                    PersonalDoc = cmbDocument.Text;
                    break;
                case "Pasaporte":
                    mtbnit.Mask = "L00000000";
                    CheckMissInfo(mtbnit, check);
                    PersonalDoc = cmbDocument.Text;
                    break;
                default:
                    check = false;
                    CheckMissInfo(mtbnit, check);                
                    break;
            }
        }


        private void CheckMissInfo(MaskedTextBox A, bool Checked) 
        {
            if (Checked != true)
            {
                errorProvider1.SetError(A, "Por favor brinde la informacion correcta.");
                btnSiguiente.Hide();
            }
            else
            {
                errorProvider1.SetError(A, "");
                btnSiguiente.Show();

            }
        }

        private int GetEdadUser(DateTime BirthDate)
        {
            //Calculamos los años con la siguiente formula.
            int year = System.DateTime.Now.Year - BirthDate.Year;
            //verificamos aparte del año si ya pasamos de la fecha de nacimiento de este año o nos faltan dias.
            if (System.DateTime.Now.Subtract(BirthDate.AddYears(year)).TotalDays < 0)
            {
                int yearsOld = year - 1;

                return yearsOld;
            }
            else 
            {
                return year;
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {           
            frmLogIn go = new frmLogIn();
            go.Show();
            this.Close();

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if(validateControls())
            {
                try
                {
                    //Se conecta a la base de datos
                    conexion.Conectar();
                    string RegistrarUsuario;
                    RegistrarUsuario = "INSERT INTO [dbo].[users]([first_name],[last_name],[password],[email],[nit],[dui],[dirrection],[age],[country_id],[birth_date],[gender],[id_role])";
                    RegistrarUsuario += "VALUES  (@Nombre, @Apelli, @contra, @correo, @nit, @dui,  @direccion, @edad, @country_id, @fechaNacimiento, @genero, @id_role)";
                    //Creamos el comando de SQL
                    SqlCommand InsertInto = new SqlCommand(RegistrarUsuario, conexion.Conn);
                    //Le damos parametros al comando, y a sus respectivas variables los valores.
                    InsertInto.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar, 100));
                    InsertInto.Parameters["@Nombre"].Value = txtname.Text;
                    InsertInto.Parameters.Add(new SqlParameter("@Apelli", SqlDbType.VarChar, 100));
                    InsertInto.Parameters["@Apelli"].Value = txtapelli.Text;
                    InsertInto.Parameters.Add(new SqlParameter("@contra", SqlDbType.VarChar, 100));
                    InsertInto.Parameters["@contra"].Value = txtpassword.Text;
                    InsertInto.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar, 255));
                    InsertInto.Parameters["@correo"].Value = txtemail.Text;
                    InsertInto.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar, 255));
                    InsertInto.Parameters["@direccion"].Value = cmb_departamento.Text;

                    InsertInto.Parameters.Add(new SqlParameter("@country_id", SqlDbType.Int, 4));
                    InsertInto.Parameters["@country_id"].Value = id;

                    InsertInto.Parameters.Add(new SqlParameter("@edad", SqlDbType.Int, 4));
                    InsertInto.Parameters["@edad"].Value = GetEdadUser(DtpBirthDate.Value);
                    InsertInto.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.DateTime));
                    InsertInto.Parameters["@fechaNacimiento"].Value = DtpBirthDate.Value;//.ToString("yy/mm/dd");
                    InsertInto.Parameters.Add(new SqlParameter("@genero", SqlDbType.Char, 1));
                    InsertInto.Parameters["@genero"].Value = g;
                    InsertInto.Parameters.Add(new SqlParameter("@id_role", SqlDbType.Int, 4));
                    InsertInto.Parameters["@id_role"].Value = 2;
                    //Para el tipo de documento personal que brindo.
                    InsertInto.Parameters.Add(new SqlParameter("@nit", SqlDbType.Char, 14));
                    InsertInto.Parameters.Add(new SqlParameter("@dui", SqlDbType.Char, 9));
                    //InsertInto.Parameters.Add(new SqlParameter("@pasaporte", SqlDbType.VarChar, 255)); //Comentariado temporalmente

                    InsertInto.Parameters["@nit"].Value = PersonalInfo("NIT");
                    InsertInto.Parameters["@dui"].Value = PersonalInfo("DUI");
                    //InsertInto.Parameters["@pasaporte"].Value = PersonalInfo("Pasaporte"); //Comenteriado temporalmente
                    //Ejecutamos el Query
                    InsertInto.ExecuteNonQuery();
                    frmLogIn.user = txtemail.Text;
                    FrmMenuUsuario WelcomeUser = new FrmMenuUsuario();
                    this.Close();
                    WelcomeUser.Show();

                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.Cerrar();
                }
            }
            else
            {
                validateControls();
            }

        }

        private void ini()
        {
            txtpassword.PasswordChar = txtPasswordConfirmed.PasswordChar = '*';
            conexion.Conectar();
            cmb_Country.Items.Clear();
            string info = "select * FROM Country";
            command = new SqlCommand(info, conexion.Conn);
            adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adapt.Fill(ds);
            SqlDataReader dr;
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                string name = dr["name"].ToString();
                cmb_Country.Items.Add(name);
            }

            conexion.Cerrar();
            
            

        }

        private void cmb_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            p = cmb_Country.Text;
            conexion.Conectar();
            string info = "select id FROM Country where name=@name";
            command = new SqlCommand(info, conexion.Conn);
            command.Parameters.AddWithValue("name", p);
            adapt = new SqlDataAdapter(command);
            DataTable dit = new DataTable();
            adapt.Fill(dit);

            id = Convert.ToInt32(dit.Rows[0][0]);

            cmb_departamento.Items.Clear();
            string query = "select * FROM States where id_Country=@id";
            command = new SqlCommand(query, conexion.Conn);
            command.Parameters.AddWithValue("id", id);
            adapt = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            adapt.Fill(ds);
            SqlDataReader dr;
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                string name = dr["name"].ToString();
                cmb_departamento.Items.Add(name);
            }

            conexion.Cerrar();
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void rbtn_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            g = Convert.ToChar(rbtn_Masculino.Text);
        }

        private void rbtn_Femenino_CheckedChanged(object sender, EventArgs e)
        {
            g = Convert.ToChar(rbtn_Femenino.Text);
        }

        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtapelli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        

        private void rbtn_Nit_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbx_NIT_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        //Facilita la validacion de los campos y muestra sus error provider dependiendo de cual de ellos esta mal
        private bool validateControls()
        {
            bool valid = validarEmail(txtemail.Text);

            if (txtname.Text != "" && txtapelli.Text != "" && txtpassword.Text == txtPasswordConfirmed.Text && txtpassword.Text != "" && txtpassword.TextLength >= 6 && txtemail.Text != "" && valid == true && cmb_Country.Text != "" && cmb_departamento.Text != "" && rbtn_Femenino.Checked == true || rbtn_Masculino.Checked == true && GetEdadUser(DtpBirthDate.Value) >= 18)
            {
                return true;
            }
            else
            {
                errorProvider1.Clear();
                if (txtname.Text == "")
                {
                    errorProvider1.SetError(txtname, "Campo vacio");
                }
                if(txtapelli.Text == "")
                {
                    errorProvider1.SetError(txtapelli, "Campo vacio");
                }
                if (txtemail.Text == "")
                {
                    errorProvider1.SetError(txtemail, "Campo vacio");
                }
                if (txtpassword.TextLength < 6)
                {
                    errorProvider1.SetError(txtpassword, "Se requieren al menos 6 letras para aceptar la contraseña");
                }
                if (txtPasswordConfirmed.Text == "")
                {
                    errorProvider1.SetError(txtPasswordConfirmed, "Campo vacio");
                }
                if (txtPasswordConfirmed.Text != txtpassword.Text)
                {
                    errorProvider1.SetError(txtPasswordConfirmed, "Campo no coincide");
                }
                if (valid == false)
                {
                    errorProvider1.SetError(txtemail, "Mail invalido");
                }
                if (cmb_Country.Text == "")
                {
                    errorProvider1.SetError(cmb_Country, "Pais no valido");
                }
                if (cmb_departamento.Text == "")
                {
                    errorProvider1.SetError(cmb_departamento, "Departamento invalido");
                }
                if (rbtn_Femenino.Checked == false && rbtn_Masculino.Checked == false)
                {
                    errorProvider1.SetError(rbtn_Femenino, "Por favor marcar un genero");
                }
                if (GetEdadUser(DtpBirthDate.Value) < 18)
                {
                    errorProvider1.SetError(DtpBirthDate, "Solo se admiten mayores de 18 años");
                }
                return false;
            }
        }

        //Validaciones para verificar si la contraseña es igual.
        private void txtpassword_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Aprobación.Clear();
            if (txtpassword.Text != "")
            {
                if(txtpassword.Text == txtPasswordConfirmed.Text)
                {
                    Aprobación.SetError(txtpassword, "Contraseñas coinciden");
                }
                else
                {
                    errorProvider1.SetError(txtpassword, "Contraseñas no coinciden");
                }
            }
            else
            {
                errorProvider1.SetError(txtpassword, "Contraseña vacia");
            }
        }

        private void txtPasswordConfirmed_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Aprobación.Clear();
            if (txtpassword.Text != "")
            {
                if (txtpassword.Text == txtPasswordConfirmed.Text)
                {
                    Aprobación.SetError(txtpassword, "Contraseñas coinciden");
                }
                else
                {
                    errorProvider1.SetError(txtpassword, "Contraseñas no coinciden");
                }
            }
            else
            {
                errorProvider1.SetError(txtpassword, "Contraseña vacia");
            }
        }
    }
}
