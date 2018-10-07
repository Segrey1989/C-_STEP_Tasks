using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaceclasswork
{
    class Home
    {
       // string adress;
       // double square;

        // список того, что надо построить
        public Dictionary<string, int> Parts;

        // то, что уже существует, храняться готовые объекты
       public List<Ipart> house_state;

        public Home()
        {
            Parts = new Dictionary<string, int> {
            {"basement", 1},
            {"walls", 4},
            {"door", 1},
            {"windows", 4},
            {"roof", 1}
        };
            house_state = new List<Ipart>();
   
        }

        // готовность дома
        public bool isReady(){
            if (Parts.Any())
                return false;
            return true;
        }


    }
}