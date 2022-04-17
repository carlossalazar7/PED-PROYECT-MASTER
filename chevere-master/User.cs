using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public  int Id
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
           get => password; set => password = value ;
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
    }
}
