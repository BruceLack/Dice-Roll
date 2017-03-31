using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter the number of sides on the first die");
                int sides1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the number of sides on the second die");
                int sides2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Welcome to the Grand Circus Casino! Would you like to roll the dice? (y/n)");
                string response = Console.ReadLine();
                if (response == "y" || response == "Y")
                {
                    Boolean run = true;
                    while (run == true)
                    {
                        Console.WriteLine("You rolled " + DiceRoll(sides1) + " and " + DiceRoll2(sides2));
                        run = Continue();
                    }
                }
                else if (response == "n" || response == "N")
                {
                    Console.WriteLine("Thanks for trying your luck at the Grand Circus Casino.");
                }
        }
        public static Random rnd = new Random();
        public static int DiceRoll(int sides1)
        {
            int result1;
            //Random rnd = new Random();
            result1 = rnd.Next(1, sides1+1);
            return result1;

        }
        public static int DiceRoll2(int sides2)
        {
            int result2;
            //Random rnd = new Random();
            result2 = rnd.Next(1, sides2+1);
            return result2;
        }
        public static Boolean Continue()
        {
            Console.WriteLine("Roll again? (Y/N): ");
            string input = Console.ReadLine();
            Boolean run = true;
            input = input.ToLower();
            if (input == "n")
            {
                Console.WriteLine("Thanks for visiting Grand Circus Casino! Please come again.");
                run = false;
            }
            else if (input == "y")
            {
                run = true;
            }
            else
            {
                Console.WriteLine("That is not a valid response at the Grand Circus Casino. Roll again? (Y/N): ");
                run = Continue();
            }

            return run;
        }

    }
}
