using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Net12FinalExam
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPerson[] list = new IPerson[] { 
                new Adult(){ FirstName = "Ray", LastName = "Kim" },
                new Child(){ FirstName = "Tricia", LastName = "Kim" } 
            };

            foreach(IPerson item in list)
            {
               Console.WriteLine("First Name:" + item.FirstName + ", Laat Name:" + item.LastName);
            }
        }
    }
}
