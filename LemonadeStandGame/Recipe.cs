using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Recipe
    {
        public int pricePerCup;
        public double quantityOfLemons;
        public double quantityOfIceCubes;
        public double quantityOfSugarCubes;

        public Recipe()
        {
            pricePerCup = 0;
            quantityOfLemons = 10;
            quantityOfIceCubes = 4;
            quantityOfSugarCubes = 6;
        }

        public void MakeRecipe()
        {
            Console.WriteLine("Please make your recipe for your lemonade stand.How many sugar cubes?");
            quantityOfSugarCubes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many lemons?");
            quantityOfLemons = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many ice cubes?(Choose a number)");
            quantityOfIceCubes = Convert.ToDouble(Console.ReadLine());
        }
    }
}
