using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_classes_
{
    class Item
    {
        string name;
        double price;
        string description { get; set; }
        public Item(string _name, double _price)
        {
            name = _name;
            price = _price;
        }
        public string getName() { return name; }
        public double getPrice() { return price; }
    }
}
