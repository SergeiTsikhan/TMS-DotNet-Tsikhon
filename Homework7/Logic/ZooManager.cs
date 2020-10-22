using Homework7.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7.Logic
{
    class ZooManager : IZooManager
    {
        public List<Animalbase<int>> Animals { get; set; } = new List<Animalbase<int>>();

        public void Show()
        {
            foreach(var animal in Animals)
            {
                Console.WriteLine($"Animal height:{animal.Height}");
            }
        }
    }
}
