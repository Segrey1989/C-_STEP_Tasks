using System;
namespace Items
{
    public class Chemicals:ItemBasic
    {
        string bestfor;
        double weight { get; set; }

        public Chemicals(string _name, double _cost, string _bestfor):base(_name, _cost)
        {
            bestfor = _bestfor; 
        }

        public override void showItem()
        {
            base.showItem();
            Console.WriteLine("Best before: {0}\nWeight: {1}\n",
                              bestfor, weight);

        }
    }
}
