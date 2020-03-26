using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        private Player player;
        private List<Day> days;
        private int currentDay;

        public Game()
        {
            player = new Player();
            days = new List<Day>();
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
            int userInput;

            for ()
            {
                Console.WriteLine("Pick an option:");
                Console.WriteLine("Check inventory, go to store, make recipe, select current day, choose weather");
                
            }
        }



    }
}
