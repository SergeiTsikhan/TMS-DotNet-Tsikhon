using Homework7.Enum;
using Homework7.Interface;
using Homework7.Logic;
using Homework7.Random_class;
using System;

namespace Homework7
{
    class Program
    {
        static void Main(string[] args)
        {
            var monkey = new Monkey("JOJO", 8, Kind.Mammals)
            {
                Height = 12
            };

            var greywolf = new Wolf("White Fang", 3, Kind.Mammals)
            {
                Height = 8
            };
            greywolf.ShowInfo();
            monkey.ShowInfo();
            Console.WriteLine("=========");
            IZooManager zoomanager = new ZooManager();

            zoomanager.Animals.Add(greywolf);
            zoomanager.Animals.Add(monkey);

            zoomanager.Show();

        }
    }
}
