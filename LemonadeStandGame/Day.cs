using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Day
    {
        
        public Weather weather;
        public List<Customer> customer;
        Random random = new Random();
        private List<Customer> customers;

        public Day()
        {
            customers = new List<Customer>();

        }

       
        private int NumberOfCustomers()
        {
            int numberOfCustomers = 0;
            if (weather.weatherTempurature <= 100)
            {
                numberOfCustomers = random.Next();
            }
            else if(weather.weatherTempurature <= 80)
            {
                numberOfCustomers = random.Next();
            }
            else if(weather.weatherTempurature <= 65)
            {
                numberOfCustomers = random.Next();
            }
            else if(weather.weatherTempurature <= 75)
            {
                numberOfCustomers = random.Next();
            }
            else if(weather.weatherTempurature <= 90)
            {
                numberOfCustomers = random.Next();
            }
            return numberOfCustomers;
        }



    }
}
