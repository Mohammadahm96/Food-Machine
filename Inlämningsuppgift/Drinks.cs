using Inlämmningsuppgift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift
{
    class Drinks : MenuItems, iShop
    {
        //Attribut
        public string carbonated;

        //Konstruktor
        public Drinks(string name, int id, string description, string orderID, int OrderCost, string carbonated) : base(name, id, description, orderID)
        {
            this.carbonated = carbonated;
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
