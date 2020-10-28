using Homework7.Logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7.Interface
{
    interface IZooManager
    {
       List<Animalbase<int>> Animals { get; set; }
        void Show();
    }
}
