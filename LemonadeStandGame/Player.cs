using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Recipe recipe;
        public Wallet wallet; 
        public Pitcher pitcher;
        public string RemainingCups { get; set; }

        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = new Wallet();
            pitcher = new Pitcher();
        }

        public void Display()
        {
            Console.WriteLine($"You have {inventory.cups.Count} lasting");
            Console.WriteLine($"You have {inventory.lemons.Count} lasting");
            Console.WriteLine($"You have { inventory.iceCubes.Count} lasting");
            Console.WriteLine($"You have {inventory.sugarCubes.Count} lasting");
        }
        
        public void CupsInPitcher()
        {
            Console.WriteLine($"You have this many {RemainingCups} in the pitcher.");
        }
    }

    
}
