using System;
namespace Items
{
    public class FoodItem:ItemBasic
    {
        string bestfor { get; set; }
        double weight { get; set; }
        //public double Weight
        //{
        //    get
        //    {
        //        return weight;
        //    }
        //    set
        //    {
        //        weight = value;
        //    }

        //}
       
        public FoodItem(string nam, double _cost, string bf): base(nam, _cost)
        {
            bestfor = bf;
        }

        public override void showItem(){
            base.showItem();
            Console.WriteLine("Best before: {0}\nWeight: {1}\n",
                              bestfor, weight);

        }
    }
}
