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
            //CalculateCircleArea();
            Adding();
            //Saskaitisana();
            //CircleArea();
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
