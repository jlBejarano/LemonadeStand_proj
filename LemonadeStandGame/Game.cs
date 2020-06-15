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
        string choiceOfPurchase;

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
            DecideNumberOfDays();
            Console.WriteLine("To start day one press enter!");
            Console.ReadLine();
            for (int i = 1; i <= Days.Count; i++)
            {
                Createcustomers();
                Weather weather = new Weather();
                newPlayer.inventory.DisplayInventory();
                newPlayer.wallet.DisplayAmountOfMoney();
                ChoiceOfPurchase();
                ChooseWhatToBuy();
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
        public void DecideNumberOfDays()
        {
            while (numberOfDays != 7 && numberOfDays != 14 && numberOfDays != 30)
            {
                Console.WriteLine($"{newPlayer.name},How many days to run the stand? \nType 7 for 7 days.\nType 14 for 14 days.\nType30 for 30 days.");
                string userInput = Console.ReadLine();
                if(userInput == "7" || userInput == "14" || userInput == "30")
                {
                    numberOfDays = Convert.ToInt32(userInput);
                    for (int i = 0; i < numberOfDays; i++)
                    {
                        Day day = new Day();
                        Days.Add(day);
                    }
                }
                else
                {
                    Console.WriteLine("Not valid option.");
                }
            }
        }

        public void ChoiceOfPurchase()
        {
            while (choiceOfPurchase != "1" && choiceOfPurchase != "2")
            {
                Console.WriteLine("What items would you like to purchase?");
                choiceOfPurchase = Console.ReadLine();
                if (choiceOfPurchase != "1" && choiceOfPurchase != "2")
                {
                    Console.WriteLine("Not Valid Option");
                }
            }
        }

        public void ChooseWhatToBuy()
        {
            while(choiceOfPurchase == "1")
            {
                newPlayer.wallet.DisplayAmountOfMoney();
                newPlayer.inventory.DisplayInventory();
                Console.WriteLine($"Type 1 to buy more lemons\nType 2 to purchase more Cups\nType 3 to purchase more sugar cubes\nType 4 to purchase more Ice Cubes");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    store.SellLemons(newPlayer);
                }
                else if (userInput == "2")
                {
                    store.SellCups(newPlayer);
                }
                else if (userInput == "3")
                {
                    store.SellSugarCubes(newPlayer);
                }
                else if (userInput == "4")
                {
                    store.SellIceCubes(newPlayer);
                }
                else
                {
                    Console.WriteLine("Not Valid Option");
                }   
        
            }
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
