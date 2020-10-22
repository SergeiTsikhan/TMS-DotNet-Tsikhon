using Homework7.Enum;
using Homework7.Interface;
using Homework7.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7.Random_class
{
    class Monkey : Animalbase<int>, IMonkey
    {
        public Monkey(string name, int age, Kind kind) : base(name, age, kind)
        {

        }

        public void EatBanana()
        {
            Console.WriteLine("I like eat banana"); ;
        }
    }
}
