using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList list = new ToDoList();

            while (true)
            {
                Console.WriteLine("Add thing to do:");
                string todoTask = Console.ReadLine();
                list.AddNewTodo(todoTask);
                list.ShowAllTodos();

               // Console.WriteLine("b - Add things to do");

            }

            
        }
    }
}
