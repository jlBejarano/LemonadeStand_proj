using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Game
    {
        Player player;
        Random random = new Random();
        Store store;
        List<Day> Days;
        int numberOfDays;

        public Game()
        {
            player = new Player();
            store = new Store();
            Days = new List<Day>();
            numberOfDays = 0;
         
        }


        public void RunGame()
        {
            Console.WriteLine("Welcome to The Lemonade Stand Game!");
            Console.ReadLine();
            CreatePlayer();
            Console.WriteLine("To start day one press enter!");
            Console.ReadLine();
            for (int i = 1; i <= Days.Count; i++)
            {
                Weather weather = new Weather();
                Console.WriteLine($"Day {i} of {numberOfDays}");
                Console.WriteLine($"\nTempurature:{weather.weatherCondition}\n");
                int days = 0;
                do
                {
                    i++;
                    if (player.wallet.Money >= 0.00)
                    {
                        GameMenu();
                    }
                    else
                    {

                    }
                    Console.WriteLine("You have no more money!");

                }
                while (i <= 7);

                Console.ReadLine();
            }
            

            
        
        }


        public void DisplayRules()
        {
            Console.WriteLine("Game Instructions: \n Sell as many lemonade cups in 7, 14, or 30 days to make as much money as you can.");

        }
        public void CreatePlayer()
        {
            Console.WriteLine("New player enter your name:");
            Console.ReadLine();
        }

        public void GameMenu()
        {
            Console.WriteLine("Enter option to start game");
            Console.WriteLine($"\n1 Inventory \n2 Make recipe \n3 Store run \n4 Begin the day");

        }




    }
}
