using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Customer
    {
        public string name;
        public int customers;
        private List<string> names;
        Random random = new Random();

        public Customer(List<string> names, int customers)
        {
            
        }

        public bool MakeChoice()
        {
            int chanceNumber = 0;
            if(chanceNumber >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
