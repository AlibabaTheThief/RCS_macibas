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
            Console.WriteLine("Now you need to guess:");
            
            while (true)
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
                
            }
          

        }
    }
}
