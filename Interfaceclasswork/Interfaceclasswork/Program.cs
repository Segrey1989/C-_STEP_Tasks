using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaceclasswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Home h = new Home();
            Worker w1 = new Worker("Andy Shine");
            Worker w2 = new Worker("Lilly Monro");
            Leader l = new Leader("Gary Lebovski");

            w1.buildPart(h, "basement");
            w2.buildPart(h, "basement"); //будет проигнорировано, т.к уже есть
            w2.buildPart(h, "walls");
            w1.buildPart(h, "door");
            w2.buildPart(h, "windows");
            w1.buildPart(h, "roof");
            l.getState(h);
        }
    }
}
