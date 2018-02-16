using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListApp
{
    class ToDoList
    {
        public ToDoList()
        {
            todoEntries = new List<string>();
        }
        List<string> todoEntries;

        public void AddNewTodo(string task)
        {
            Console.WriteLine("Task added " + task);
            todoEntries.Add(task);
        }

        public void ShowAllTodos()
        {
            for (int i = 0; i > todoEntries.Count; i++)
            {
                Console.WriteLine("Your to does " + todoEntries[i]);
            }
            
        }



    }
}
