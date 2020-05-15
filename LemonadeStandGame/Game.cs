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

        public void GameMenu()
        {
            Console.WriteLine("Pick an option");
              
            
        }

        public void RunGame()
        {
           
            Console.WriteLine("Welcome to Lemonade Stand");
            Console.ReadLine();
        }



    }
}
