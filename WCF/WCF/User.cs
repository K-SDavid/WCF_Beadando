using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Web;

namespace WCF
{
    [DataContract]
    public class User
    {
        Regex regex = new Regex(@"\s{2,}");

        public User()
        {

        }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        [DataMember]
        public int Id { get; set; }

        string username;

        [DataMember]
        public string Username
        {
            get { return username; }
            set
            {
                if (value == null)
                    throw new Exception("Kérem adjon meg felhasználónevet!");
                if (value.Trim().Length < 4)
                    throw new Exception("A felhasználónév hossza nem lehet rövidebb 4 karakternél!");
                if (regex.IsMatch(value))
                    throw new Exception("Nem lehet kettő space egymás mellett a felhasználónévben!");
                username = value;
            }
        }

        string password;

        [DataMember]
        public string Password
        {
            get { return password; }
            set
            {
                if (value == null)
                    throw new Exception("Kérem adjon meg egy jelszót!");
                if (value.Trim().Length < 4)
                    throw new Exception("A jelszó hossza nem lehet rövidebb 4 karakternél!");
                if (regex.IsMatch(value))
                    throw new Exception("Nem lehet kettő space egymás mellett a jelszóban!");
                password = value;
            }
        }
    }
}