using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    public class Game
    {
        Player newPlayer;
        Random random = new Random();
        Customer customer;
        List<Customer> Customers;
        Store store;
        List<Day> Days;
        int numberOfDays;
        double priceOfLemonade;
        string decideToPurchase;

        public Game()
        {
           
            store = new Store();
            Days = new List<Day>();
            numberOfDays = 0;
            customer = new Customer();
            Customers = new List<Customer>();
            
         
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
                Createcustomers();
                Weather weather = new Weather();
                newPlayer.inventory.DisplayInventory();
                newPlayer.wallet.DisplayAmountOfMoney();
                decideToPurchase = null;
                Console.WriteLine($"Day {i} of {numberOfDays}");
                Console.WriteLine($"\nTempurature:{weather.weatherCondition}\n");
                newPlayer.inventory.iceCubes.Clear();
                Console.WriteLine("\nPress enter to start the next day."); ;
            }   
        }

       

        public void ChoosePriceOfLemonade()
        {
            Console.WriteLine("Enter price for lemonade cups");
            priceOfLemonade = Convert.ToDouble(Console.ReadLine());
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
       

        public void Createcustomers()
        {
            for (int i = 0; i < 100; i++)
            {
                Customer customer = new Customer();
                Customers.Add(customer);
            }
        }



    }
}
