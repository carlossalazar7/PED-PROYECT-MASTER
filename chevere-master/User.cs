using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chevere_master
{
    internal class User
    {
        private int id;
        private string firstName;
        private string lastName;
        private static string email;
        private static string password;
        private int nit;
        private int dui;
        private string dirrection;
        private int age;
        private string nationality;
        private DateTime birthDate;
        private string gender;
        private int id_role;

        private SqlDataAdapter dataAdapter;
        private SqlDataReader dataReader;
        private SqlCommand command;

        Conexion conexion = new Conexion();
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get => lastName; set => lastName = value;
        }
        public string Email
        {
            get => email; set => email = value;
        }
        public string Password
        {
            get => password; set => password = value;
        }
        public int Nit
        {
            get => nit; set => nit = value;
        }
        public int Dui
        {
            get => dui; set => dui = value;
        }
        public string Dirrection
        {
            get => dirrection; set => dirrection = value;
        }
        public int Age
        {
            get => age; set => age = value;
        }
        public string Nationality
        {
            get => nationality; set => nationality = value;
        }
        public DateTime BirthDate
        {
            get => birthDate; set => birthDate = value;
        }
        public string Gender
        {
            get => gender; set => gender = value;
        }
        public int Id_role
        {
            get => id_role; set => id_role = value;
        }

        public DataTable SeachUser(string usuario)
        {
            string sql = "SELECT u.id, u.first_name, u.last_name, r.name   FROM users u INNER JOIN roles r on  r.id = u.id_role  WHERE email = @usuario";

            //abriendo conexion
            conexion.Conectar();
            command = new SqlCommand(sql, conexion.Conn);
            command.Parameters.AddWithValue("usuario", usuario);


            dataAdapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public bool ChangePassword(string email, string password)
        {
            string sql = "UPDATE users SET password = @password WHERE email = @email";
            int rowsAffected = 0;
            try
            {
                //abriendo conexion
                conexion.Conectar();
                command = new SqlCommand(sql, conexion.Conn);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("email", email);
                rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected != 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario en la BD: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rowsAffected = 0;
                return false;
            }
            finally
            {
                conexion.Cerrar();
            }
            
        }
    }
}

