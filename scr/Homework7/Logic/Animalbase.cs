using Homework7.Enum;
using Homework7.Interface;
using System;

namespace Homework7.Logic
{
    abstract class Animalbase<T> : IAnimalbase
    {

        public T Height { get; set; }


        private readonly Guid ID = Guid.NewGuid();
        private string _name;
        private int _age;
        private Kind _kind = Kind.Unknown;
        private string _passport = Guid.NewGuid().ToString().Substring(0, 8);

        public Animalbase(string name, int age, Kind kind)
        {
            _name = name;
            _age = age;
            _kind = kind;

        }

            public void ShowInfo()
        {
            Console.WriteLine("=========");
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine($"Animal name:{_name}");
            Console.WriteLine($"Animal age: {_age}");
            Console.WriteLine($"Animal Kind: {_kind}");
            Console.WriteLine($"Animal passport: {_passport}");
            Console.WriteLine("=========");
        }

    }
}