using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Inlämmningsuppgift
{
    abstract internal class MenuItems
    {
        //Attribut
        public string name;
        public int id;
        public string description;
        public string orderID;
        public int OrderCost;

        public MenuItems(string name, int id, string description, string orderID) : this(name, id, description)
        {
        }




        // Konstruktor
        public MenuItems(string name, int id, string description, string orderID, int orderCost)
        {
            this.name = name;
            this.id = id;
            this.description = description;
            this.orderID = orderID;
            this.OrderCost = orderCost;



        }

        protected MenuItems(string name, int id, string description)
        {
            this.name = name;
            this.id = id;
            this.description = description;
            
        }
    }

}
