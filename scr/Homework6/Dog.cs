using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Dog : AnimalBase<string>, Ijump, Isay
    {
        public void Jump()
        {
            Console.WriteLine("I can jump!"); ;
        }


        public void say()
        {
            Console.WriteLine("Gav");
        }
    }
}
