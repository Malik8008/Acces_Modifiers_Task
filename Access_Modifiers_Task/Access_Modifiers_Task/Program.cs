using System;
using System.Text.RegularExpressions;

namespace Access_Modifiers_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin(true, "Full");

            admin.GetInfo();

        }
    }  
}
