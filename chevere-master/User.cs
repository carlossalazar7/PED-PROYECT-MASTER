using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chevere_master
{
    internal class User
    {
        private static int id;
        private static string firstName;
        private static string lastName;
        private static string email;
        private static string password;
        private static int nit;
        private static int dui;
        private static string dirrection;
        private static int age;
        private static string nationality;
        private static DateTime birthDate;
        private static string gender;
        private static int id_role;

        public static int Id
        {
            get { return id; }
            set { id = value; }
        }
        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public static string LastName
        {
            get => lastName; set => lastName = value;
        }
        public static string Email
        {
            get => email; set => email = value;
        }
        public static string Password
        {
           get => password; set => password = value ;
        }
        public static int Nit
        {
            get => nit; set => nit = value;
        }
        public static int Dui
        {
            get => dui; set => dui = value;
        }
        public static string Dirrection
        {
            get => dirrection; set => dirrection = value;
        }
        public static int Age
        {
            get => age; set => age = value;
        }
        public static string Nationality
        {
            get => nationality; set => nationality = value;
        }
        public static DateTime BirthDate
        {
            get => birthDate; set => birthDate = value;
        }
        public static string Gender
        {
            get => gender; set => gender = value;
        }
        public static int Id_role
        {
            get => id_role; set => id_role = value;
        }
    }
}
