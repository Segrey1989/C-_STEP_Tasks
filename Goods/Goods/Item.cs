using System;
namespace Goods
{
    class Item
    {
        readonly string name;         double price;         string description; //{ get; set; }

        public Item(string _name, double _price, string _description = "")
        {
            name = _name;
            price = _price;
            description = _description;
        }


        public string Name
        {
            get {return name; }
        }


        public double Price
        {
            get { return price; }
            set { price = value; }

        }

        public string Description{
            get{return description;}
            set { description = value; }
                
        }
             //   public string getName() { return name; }         //public double getPrice() { return price; } 
    }
}
