using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Recipe
    {
        public double pricePerCup;
        public int quantityOfLemons;
        public int quantityOfIceCubes;
        public int quantityOfSugarCubes;

        public Recipe()
        {
            pricePerCup = .20;
            quantityOfLemons = 10;
            quantityOfIceCubes = 4;
            quantityOfSugarCubes = 6;
        }

        public void MakeRecipe()
        {
            pricePerCup = UserInterface.GetUserInputDouble("How many cups would you like to have");
            quantityOfLemons = UserInterface.GetUserInputInt("Amount of lemons you would like");
            quantityOfIceCubes = UserInterface.GetUserInputInt("Amount of ice cubes you would like");
            quantityOfSugarCubes = UserInterface.GetUserInputInt("Amount of sugar cubes you would like");
        }

    }
}
