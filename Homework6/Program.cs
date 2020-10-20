using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tom = new Dog()
            {
                Name = "Tom",
                Age = "9",
            };
            Imanager zoomanager = new Manager();
            zoomanager.Animal.Add(Tom);

            Tom.say();
            Tom.Jump();





        }
    }
}
