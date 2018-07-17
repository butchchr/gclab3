using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gclab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool y = true;
            while (y)
            {

                Console.WriteLine("Hello user! Please Enter your name: ");
                string userName = Console.ReadLine();

                //code in a isNullOrWhiteSpace check Console.WriteLine("Sorry I didn't catch that. Please enter your name:") 

                Console.WriteLine(userName + " you say? That is a fine name!");
                Console.WriteLine(userName + " please enter a integer between 1 and 100");
                string userNum = Console.ReadLine();

                int userInt;
                bool num1 = int.TryParse(userNum, out userInt);

                if (!(num1))
                {
                    Console.WriteLine("Input is not a number");
                }

                if (!(userInt >= 1 && userInt <= 100))
                {
                    Console.WriteLine("Input is not in range");
                }

                if (userInt % 2 == 0 && userInt >=2 && userInt <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                
                if (userInt % 2 == 0 && userInt >= 26 && userInt <= 60)
                {
                    Console.WriteLine("Even");
                }

                if (userInt % 2 == 0 && userInt >= 61 && userInt <= 100)
                {
                    Console.WriteLine(userNum + " Even");
                    return;
                }

                else if (!(userInt % 2 == 0))
                {
                    Console.WriteLine(userNum + " is an odd number");
                }

                bool invalid = true;
                while (invalid)
                {
                    Console.WriteLine("Continue? (y/n):");
                    ConsoleKeyInfo pressed = Console.ReadKey();
                    Console.WriteLine();
                    bool isY = pressed.Key == ConsoleKey.Y;
                    bool isN = pressed.Key == ConsoleKey.N;

                    invalid = !isY && !isN;
                    y = isY;
                }
            }
        }
    }
}
