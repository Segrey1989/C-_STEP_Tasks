using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaceclasswork
{
    interface IWorker
    {

        void buildPart(Home h, string s);
        string Name { get; }
    }
}
