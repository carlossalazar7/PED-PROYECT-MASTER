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
    public partial class CreateAccount : Form
    {
        //conexion bd
        private static Conexion conexion = new Conexion();
        //Variables a usar
        private bool Ok;
        private string PersonalDoc;

        public CreateAccount()
        {
            InitializeComponent();
            Ok = true;
            
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                //Se conecta a la base de datos
                conexion.Conectar();
                string RegistrarUsuario;
                RegistrarUsuario = "INSERT INTO [dbo].[users]([first_name],[last_name],[password],[email],[nit],[dui],[dirrection],[age],[nationality],[birth_date],[gender],[id_role])";
                RegistrarUsuario += "VALUES  (@Nombre, @Apelli, @contra, @correo, @nit, @dui,  @direccion, @edad, @pasaporte, @fechaNacimiento, @genero, @id_role)";
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
                InsertInto.Parameters["@direccion"].Value = txtaddress.Text;
                InsertInto.Parameters.Add(new SqlParameter("@edad", SqlDbType.Int, 4));
                InsertInto.Parameters["@edad"].Value = GetEdadUser(DtpBirthDate.Value);
                InsertInto.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.DateTime));
                InsertInto.Parameters["@fechaNacimiento"].Value = DtpBirthDate.Value;//.ToString("yy/mm/dd");
                InsertInto.Parameters.Add(new SqlParameter("@genero", SqlDbType.Char, 1));
                InsertInto.Parameters["@genero"].Value = cmbgen.Text;
                InsertInto.Parameters.Add(new SqlParameter("@id_role", SqlDbType.Int, 4));
                InsertInto.Parameters["@id_role"].Value = 2;
                //Para el tipo de documento personal que brindo.
                InsertInto.Parameters.Add(new SqlParameter("@nit", SqlDbType.Char, 14));
                InsertInto.Parameters.Add(new SqlParameter("@dui", SqlDbType.Char, 9));
                InsertInto.Parameters.Add(new SqlParameter("@pasaporte", SqlDbType.VarChar, 255));

                InsertInto.Parameters["@nit"].Value = PersonalInfo("NIT");
                InsertInto.Parameters["@dui"].Value = PersonalInfo("DUI");
                InsertInto.Parameters["@pasaporte"].Value = PersonalInfo("Pasaporte");
                //Ejecutamos el Query
                InsertInto.ExecuteNonQuery();
                FrmUsuario WelcomeUser = new FrmUsuario();
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


        private string PersonalInfo(string InfoCompara) 
        {
            if (cmbDocument.Text == InfoCompara) return mtbnit.Text;
            else return " ";

        }

        //Para regresar a login.
        private void label3_Click(object sender, EventArgs e)
        {
            Login Goback = new Login();
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
                btnCrearCuenta.Hide();
            }
            else
            {
                errorProvider1.SetError(A, "");
                btnCrearCuenta.Show();

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login go = new Login();
            go.Show();
        }
    }
}
