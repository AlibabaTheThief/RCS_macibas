using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rinka_linija
{
    class Program
    {
        static void Main(string[] args)
        {
            string usersInput = " ";
            while (true)
            {
                Console.WriteLine("Please choose action");
                Console.WriteLine("a - calculate circle area");
                Console.WriteLine("c - count two numbers together");
                Console.WriteLine("d - check number division");
                Console.WriteLine("x - to exit");
                usersInput = Console.ReadLine();
                if (usersInput == "a")
                {
                    CalculateCircleArea();
                }
                else if (usersInput == "c")
                {
                    Adding();
                }
                else if (usersInput == "d")
                {
                    DoesTheNumberDivide();
                }
                else if (usersInput == "x")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a or c");
                }
            }
           
            Console.ReadLine();
            

            //CalculateCircleArea();
            //Adding();
            //Saskaitisana();
            //CircleArea();
            // iegust lietotaja izveli un sagaba to mainigaja
            //Izvele();
            // izmantojot if un salidzinasanu
            // balstoties uz lietotaja izveleta skaitla
            // pienem lemumu kuru funkciju izpildit

        }
        static void DoesTheNumberDivide()
        {
            double dalamais = GetNumberFromUser("Enter dividable number");
            double dalitajs = GetNumberFromUser("Enter number to divide");
            double module = dalamais % dalitajs;
            if (module == 0)
            {
                Console.WriteLine("Can divide");
            }
            else
            {
                Console.WriteLine("Can't divide");
            }
            Console.ReadLine();
        }

        static void Izvele()
        {
            // izvada lietotajam pazinojumu
            // spied 1 lai aprekinatu laukumu
            // spied 2 lai ...
            // saparse lietotaja ievadito tekstu uz skaitli
            // atgriez ieguto lietotaja skaitlisko izveli
        }

        static void CircleArea()
        {
            Console.WriteLine("Enter radius");

            double radius = Convert.ToDouble(Console.ReadLine());
            double result;
            result = radius * radius * 3.14;
            Console.WriteLine("Rezultats: " + result);
            Console.ReadLine();
        }

        static void Saskaitisana()
        {
            Console.WriteLine("Enter first number:");

            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result;
            result = num1 + num2;
            Console.WriteLine("Rezultats: " + result);
            Console.ReadLine();
        }

        static void CalculateCircleArea()
        {
            double radius;
            double result;
            radius = GetNumberFromUser("Enter radius");
            result = radius * radius * 3.14;
            Console.WriteLine("Rezultats: " + result);
            Console.ReadLine();

        }

        static void Adding()
        {
            double firstNumber;
            firstNumber = GetNumberFromUser("First number:");
            double secondNumber;
            secondNumber = GetNumberFromUser("second number:");
            double result;
            result = firstNumber + secondNumber;
            Console.WriteLine("Rezultats: " + result);
            Console.ReadLine();

        }

        static double GetNumberFromUser(string msg)
        {
            Console.WriteLine(msg);
            string textInput = Console.ReadLine();
            double parsedNumber;
            bool parseWasSucess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSucess == false)
            {
                Console.WriteLine("Ievadiet skaitli velreiz");
                parsedNumber = GetNumberFromUser(msg);
            }
            return parsedNumber;
        }
    }
}
