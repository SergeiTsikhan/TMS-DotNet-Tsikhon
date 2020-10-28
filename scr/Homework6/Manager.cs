using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class Manager:Imanager
    {
        List<AnimalBase<string>> Animal { get; set; } = new List<AnimalBase<string>>();
        List<AnimalBase<string>> Imanager.Animal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            Console.WriteLine("all"); ;
        }
    }
}
