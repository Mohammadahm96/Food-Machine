using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    public class Person
    {
        //Attribut
        public string FirstName;
        public string LastName;
        private string name;
        private string phoneNum;

        //Konstruktor
        public Person(string name, string address, int age, int phoneNum)
        {
            
            FirstName = name;
            LastName = name;
            CustomerName = name;
            Address = address;




        }

        public Person(string name, string address, int age, string phoneNum)
        {
            this.name = name;
            Address = address;
            this.phoneNum = phoneNum;
        }

        //Metod
        public string CustomerName { get; set; }
        public string Address { get; set; }


       
        

    }
}
