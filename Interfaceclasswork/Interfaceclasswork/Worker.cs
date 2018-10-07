using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaceclasswork
{
    class Worker : IWorker
    {
        public string Name { get; }

        public Worker(string _name){
            Name = _name;
        }

        // строит часть дома, если это не противоречит последовательности,
        // иначе не строит
        public void buildPart(Home home, string part_name){
            int number =0;
            if (!home.isReady())
            {
               
                if (home.Parts.FirstOrDefault().Key == part_name)
                {
                    number = home.Parts.FirstOrDefault().Value;
                    if (part_name == "basement")
                    {
                        while (number-- != 0)
                        {
                            home.house_state.Add(new Basement());

                        }
                    }else if(part_name == "walls"){
                        while (number-- != 0)
                        {
                            home.house_state.Add(new Walls());
                        }
                    }else if (part_name == "windows")
                    {
                        while (number-- != 0)
                        {
                            home.house_state.Add(new Window());
                        }
                    }else if (part_name == "door")
                    {
                        while (number-- != 0)
                        {
                            home.house_state.Add(new Door());
                        }
                    }else if (part_name == "roof")
                    {
                        while (number-- != 0)
                        {
                            home.house_state.Add(new Roof());
                        }
                    }


                }
               // Console.WriteLine($"{part_name} is ready");
                home.Parts.Remove(part_name);

            }
        }//build



    }
}
