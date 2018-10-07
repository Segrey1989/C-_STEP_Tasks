using System;
namespace Interfaceclasswork
{
     class Leader
    {
        string name;
        public Leader(string _name)
        {
               name = _name;
        }

        //информирует о состоянии стройки
        public void getState(Home home)
        {
            if (home.house_state.Count != 0)
            {
                Console.WriteLine("Was build: ");
                foreach (Ipart val in home.house_state)
                    val.show();
            } else
                Console.WriteLine("Nothing was built");
        }
    }
}