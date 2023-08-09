using Inlämmningsuppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    class Clothes : MenuItems, iShop
    {
        //Attribut
        public string lenght;
        public int size;
        //Konstruktor
        public Clothes(string name, int id, string description, string orderID, int OrderCost, string lenght) : base(name, id, description, orderID)
        {
            this.lenght = lenght;
        }
       
     


        public void buy()
        {
            throw new NotImplementedException();
        }

        public void use()
        {
            throw new NotImplementedException();
        }


        void iShop.description()
        {
            throw new NotImplementedException();
        }

    }
}
