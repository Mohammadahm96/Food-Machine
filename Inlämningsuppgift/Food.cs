using Inlämmningsuppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    internal class Food : MenuItems, iShop
    {

        //Attribut
        public int size;

        //Konstruktor
        public Food(string name, int id, string description, string orderID, int OrderCost) : base(name, id, description, orderID)
        {
            
        }

        //Metod
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
