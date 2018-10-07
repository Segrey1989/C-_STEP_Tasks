using System;
namespace Goods
{
    class Customer
    {
        string name;         string adress;         string phone; 

        public string Adress{
            get { return adress; }
            set { adress = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
         public Customer(string _name)         {             name = _name;         }     } 
    }

