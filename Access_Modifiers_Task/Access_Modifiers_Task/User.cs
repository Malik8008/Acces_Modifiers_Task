using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Task
{
    public class User
    {
        protected string _username=Console.ReadLine();
        protected string _password=Console.ReadLine();

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length> 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Duzgun username daxil edin");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length>5)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Duzgun sifre daxil edin");
                }
            }
        }
        public User()
        {
            Username = _username;
            Password = _password;           
        }
       
    }
}

