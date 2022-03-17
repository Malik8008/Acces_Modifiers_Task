using System;
using System.Collections.Generic;
using System.Text;

namespace Access_Modifiers_Task
{
    public class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(bool issuperadmin,string section) :base()
        {
            IsSuperAdmin = issuperadmin;
            Section = section;
            Username = _username;
            Password = _password;   
        }

        public void GetInfo() 
        {
            Console.WriteLine($"IsSuperadmin:{IsSuperAdmin},Section:{Section}");
        }
    }
}
