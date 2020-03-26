using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        public string name;
        public int customers;
        private List<string> names;
        Random random = new Random();

        public Customer(string name, int customer, List<string> names)
        {
           customer =  random.Next(customer.Count);
            return customer;
        }
    }
}
