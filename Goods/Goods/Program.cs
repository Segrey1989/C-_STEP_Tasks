using System;

namespace Goods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Items
            Item cheese = new Item ("Chese", 7.89 );
            cheese.Description = "Органический сыр из экологического региона";             Item book = new Item("Ulis", 18.90);
            Item fridg = new Item("Indesit", 1000, "2-x камерный холодильник категории А");
            Item pig = null;

            // ListItem             ListItem range = new ListItem();             range.putList(cheese, book, fridg, pig); 
            // Customer             Customer siarhei = new Customer("Siarhei");
            siarhei.Adress = "Минск, Краковская 6-18";


            // Bucket             Bucket myBucket = new Bucket(siarhei, "11.09.2018");             myBucket.putItem(range, fridg, cheese, book, pig);
            myBucket.makeOrder();


            range.write();           //  Console.WriteLine(fridg.Description); 
        }
    }
}
