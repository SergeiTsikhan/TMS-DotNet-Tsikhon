using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    interface Imanager
    {
        List<AnimalBase<string>> Animal { get; set; }
        void Show();
    }
}
