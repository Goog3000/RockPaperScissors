using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select one of the options: ");
            Console.WriteLine("1 - Rock");
            Console.WriteLine("2 - Paper");
            Console.WriteLine("3 - Scissors");

            Console.WriteLine("----------------------------------");

            Console.Write("Select number: ");
            uint select = UInt32.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------");

            Random value = new Random();
            int bot = value.Next(1, 3);

                if (bot == 1)
                {
                    Console.WriteLine("Computer select: Rock");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Computer select: Paper");
                }
                else if (bot == 2)
                {
                    Console.WriteLine("Computer select: Scissors");
                }


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Result: ");

            // if you had Rock
            if (select == 1 && bot == 1)
            {
                Console.WriteLine("You had Rock,Compute had Rock.\nDraw, try again.");
            }
            else if (select == 1 && bot == 2)
            {
                Console.WriteLine("You had Rock,Compute had Paper.\nYou've lost. We'll be lucky another time.");
            }
            else if (select == 1 && bot == 3)
            {
                Console.WriteLine("You had Rock, Computer had Scissors.\nYou won, Congratulations.");
            }

            // if you had Paper
            if (select == 2 && bot == 1)
            {
                Console.WriteLine("You had Paper,Compute had Rock.\nYou won, Congratulations.");
            }
            else if (select == 2 && bot == 2)
            {
                Console.WriteLine("You had Paper,Compute had Paper.\nDraw, try again.");

            }
            else if (select == 2 && bot == 3)
            {
                Console.WriteLine("You had Paper,Compute had Scissors.\nYou've lost. We'll be lucky another time.");
            }

            //if you had Scissors
            if (select == 3 && bot == 1)
            {
                Console.WriteLine("You had Scissor and Compute had Scissors.\nYou've lost. We'll be lucky another time.");
            }
            else if (select == 3 && bot == 2)
            {
                Console.WriteLine("You had Scissors and Compute had Paper.\nYou won, Congratulations.");
            }
            else if (select == 3 && bot == 3)
            {
                Console.WriteLine("You had Scissors and Compute had Scissors.\nDraw, try again.");
            }
        }
    }
}
