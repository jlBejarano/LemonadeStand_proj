using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Item
    {
        public string name;
        public double cost;
        public double quantity;

        public Item(string name, double cost, double quantity)
        {
            this.name = name;
            this.cost = cost;
            this.quantity = 0;
        }

        public void HigherQuantity(double quantity)
        {
            if (quantity > 0)
            {
                this.quantity += quantity;
            }
        }

       
        
            
        
    }
}
