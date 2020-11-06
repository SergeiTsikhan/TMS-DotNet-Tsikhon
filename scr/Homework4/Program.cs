using System;
using System.Collections.Generic;

namespace Vidos5_class_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var backlog = new List<Todo>();

                ChekStatus(backlog);
                Console.WriteLine("=============");
                ShowAlltodo(backlog);

            AddTodo(backlog);
            //ShowAlltodo(backlog);
        }
        static void ChekStatus(List<Todo> backlog)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Insert Description: ");
                var todo = new Todo
                {
                    Description = Console.ReadLine(),
                    Name = Console.ReadLine()
                };
                Console.WriteLine("___________");
                backlog.Add(todo);
                Console.WriteLine("Do you want go? (exit)");
                Console.WriteLine();
                string input = Console.ReadLine();
                if (input == "exit")
                 break;
            }
        }
        static void AddTodo(List<Todo> backlog)
        {
            while (true)
            {
                Console.WriteLine("Input Id");
                var userInput = Console.ReadLine();
                
                foreach (var todo in backlog)
                {
                    if (todo.GetID() == userInput)
                    {
                        Console.WriteLine("input to change status: (Unknown, Done, not_ready, inprocesed)");
                        string newstatus = Console.ReadLine();
                        todo.SetStatus(todo.ChangeStatus(newstatus));
                        Console.WriteLine("Doy want more change status?");
                        var exit = Console.ReadLine();
                        if (exit == "exit")
                            break;

                    }
                }
            }

        }
        static void ShowAlltodo(List<Todo>backlog )
        {
            foreach (Todo task in backlog)
            {
                task.Show();
                Console.WriteLine("=============");
            }
        }

    }
}
