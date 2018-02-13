using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World_app
{
    class Program
    {
        static void Main(string[] args)
        {
            NameAndAge();
            //SayHello();
            //SayHelloToUser();
        }

        static void NameAndAge()
        {
            Console.WriteLine("Your Name:");
            string userName;
            userName = Console.ReadLine();
            Console.WriteLine("Your Age:");
            string age;
            age = Console.ReadLine();
            Console.WriteLine("Sveiks, " + userName + " ! " + "Tu esi " + age + " gadus vecs.");
            Console.ReadLine();
        }

        static void SayHelloToUser()
        {
            Console.WriteLine("Ievadiet lietotajvardu:");
            string userName;
            userName = Console.ReadLine();
            Console.WriteLine(userName);
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!"); //rada textu
            Console.ReadLine(); //raada textu
        }
    }
}
