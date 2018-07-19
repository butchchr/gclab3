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
                //Extra bit to get the users name and call them by it
                Console.WriteLine("Hello user! Please Enter your name: ");
                string userName = Console.ReadLine();

                //code in a isNullOrWhiteSpace check Console.WriteLine("Sorry I didn't catch that. Please enter your name:") 

                //inputs for name and the int
                Console.WriteLine(userName + " you say? That is a fine name!");
                Console.WriteLine(userName + " please enter a integer between 1 and 100");
                string userNum = Console.ReadLine();

                //check to make sure it is an int
                int userInt;
                bool num1 = int.TryParse(userNum, out userInt);

                if (!(num1))
                {
                    Console.WriteLine("Input is not a integer");
                }

                //range check
                if (!(userInt >= 1 && userInt <= 100))
                {
                    Console.WriteLine("Input is not in range");
                }

                //even and under 25 check
                if (userInt % 2 == 0 && userInt >=2 && userInt <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                
                //even and 26-60 check
                if (userInt % 2 == 0 && userInt >= 26 && userInt <= 60)
                {
                    Console.WriteLine("Even");
                }

                //even and over 60 check
                if (userInt % 2 == 0 && userInt >= 61 && userInt <= 100)
                {
                    Console.WriteLine(userNum + " Even");
                    continue;
                }

                //odd check
                else if (!(userInt % 2 == 0))
                {
                    Console.WriteLine(userNum + " is an odd number");
                }

                //continue y/n
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
