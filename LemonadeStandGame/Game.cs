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
        private List<Day> days;
        private int currentDay;
        Random random = new Random();
        public int userInput;
        Store store;

        public Game()
        {
            player = new Player();
            days = new List<Day>();
            store = new Store();
            currentDay = 0;
            SetDays();

        }

        public void SetDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }
        }

        public void RunGame()
        {
            Console.WriteLine("Welcome to The Lemonade Stand Game!");
            Console.ReadLine();
        
        }


        public void DisplayRules()
        {
            Console.WriteLine("Game Instructions: \n Sell as many lemonade cups in 7, 14, or 30 days to make as much money as you can.");

        }

        public void GameMenu()
        {
            Console.WriteLine("Enter option to start game");
            Console.WriteLine($"\n1 Inventory \n2 Make recipe \n3 Store run \n4 Begin the day");

        }




    }
}
