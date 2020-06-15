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
        Random random = new Random();
        

        public Customer()
        {

           
        }

        public bool MakeChoice(Weather weather, Recipe recipe)

        {

            int chanceNumber = 0;

            if (weather.weatherCondition == "Sunny" && recipe.pricePerCup <= 0.38)

            {

                chanceNumber = random.Next(4, 10);

            }

            else if (weather.weatherCondition == "Partly Cloudy" && recipe.pricePerCup <= 0.32)

            {

                chanceNumber = random.Next(3, 10);

            }

            else if (weather.weatherCondition == "Cloudy" && recipe.pricePerCup <= 0.28)

            {

                chanceNumber = random.Next(3, 10);

            }

            else if (weather.weatherCondition == "Rainy" && recipe.pricePerCup >= 0.23)

            {

                chanceNumber = random.Next(2, 10);

            }

            else if (weather.weatherCondition == "Thunderstorms" && recipe.pricePerCup >= 0.20)

            {

                chanceNumber = random.Next(0, 10);

            }


            if (chanceNumber >= 5)
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

