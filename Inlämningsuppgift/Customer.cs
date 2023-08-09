using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    //Konstruktor
    public class Customer : Person
    {
        //Attribut
        public bool ViewProduct;
        public int Age;
        private int PhoneNum;
        //Konstruktor
        public Customer(string name, string address, int age, string phoneNum, string id, bool ViewProduct, string Email, int spentAmount)
             : base(name, address, age, phoneNum)

        {
            CustomerID = id;
            CustomerEmail = Email;
            SpentAmount = spentAmount;
            ViewedProduct = ViewProduct;
            
          

        }
        //Metod
           
        public string CustomerID { get; set; }
        public string CustomerEmail { get; set; }
        public int SpentAmount { get; set; }
        public bool ViewedProduct { get; set; }

     


    }
}
