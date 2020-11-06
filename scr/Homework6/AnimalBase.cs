using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class AnimalBase<T>
    {
        public string Age { get; set; }
        public T Name { get; set; }

    }
}
