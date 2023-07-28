using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TreasureIsland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Treasure Island.");
            Console.WriteLine("Your mission is to find the treasure.");

            Console.Write("Where do you want to go? Type \"left\" or \"right\": ");
            string choice1 = Console.ReadLine().ToLower();

            if (choice1 == "left")
            {
                Console.Write("There is a water body ahead. Type \"wait\" to wait. Type \"swim\" to swim: ");
                string choice2 = Console.ReadLine().ToLower();

                if (choice2 == "wait")
                {
                    Console.Write("Choose between 3 doors. One red, one yellow, and one blue. Which color do you choose? ");
                    string choice3 = Console.ReadLine().ToLower();

                    if (choice3 == "red")
                    {
                        Console.WriteLine("Burned by fire. Game Over.");
                    }
                    else if (choice3 == "yellow")
                    {
                        Console.WriteLine("You found the treasure! You Win!");
                    }
                    else if (choice3 == "blue")
                    {
                        Console.WriteLine("Eaten by beasts. Game Over.");
                    }
                    else
                    {
                        Console.WriteLine("That door does not exist. Game Over.");
                    }
                }
                else
                {
                    Console.WriteLine("Attacked by trout. Game Over.");
                }
            }
            else
            {
                Console.WriteLine("Fell into a hole. Game Over.");
            }
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
