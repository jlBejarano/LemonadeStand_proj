using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        
        public Weather weather;
        public Customer customer;
        Random random = new Random();
        public Day()
        {
            customer = new Customer();
            weather = new Weather();
        }

    }
}
