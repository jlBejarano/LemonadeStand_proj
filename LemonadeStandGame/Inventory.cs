using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Inventory
    {
        public List<Cup> cups;
        public List<Lemon> lemons;
        public List<IceCube> icecubes;
        public List<SugarCube> sugarcubes;

        public Inventory()
        {
            cups = new List<Cup>();

        }

    }


}
