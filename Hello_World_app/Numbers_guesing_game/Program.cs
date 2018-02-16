using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_guesing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game");
            Console.WriteLine();
            Console.WriteLine("Choose max number:");
            int maxNumber = int.Parse(Console.ReadLine());
            Random numberGenerator;
            numberGenerator = new Random();
            int number = numberGenerator.Next(1, maxNumber + 1);
            int times = 5;
            Console.WriteLine("You have " + times + " tries");
            Console.WriteLine("Now you need to guess:");


            for (int i = 0; i < times; i++)
            {
                int usersNumber = int.Parse(Console.ReadLine());
                
                if (usersNumber > number)
                {
                    Console.WriteLine("too much");
                }
                else if (usersNumber < number)
                {
                    Console.WriteLine("not enough");
                }
                else
                {
                    Console.WriteLine("Well done!");
                    Console.ReadLine();
                    break;
             
                }

                Console.WriteLine(times - i - 1 + " tries left");
                
            }
            Console.WriteLine("You lose.");
            Console.ReadLine();

        }
    }
}
