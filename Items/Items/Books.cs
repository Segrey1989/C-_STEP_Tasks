using System;
namespace Items
{
    public class Books:ItemBasic
    {
        string author;
        int pages{ get; set; }
        string IBSN { get; set; }

        public Books(string _name, double _cost, string _author):base(_name, _cost)
        {
            author = _author;
        }

        public override void showItem()
        {
            base.showItem();
            Console.WriteLine("Author: {0}\nPages: {1}\nIBSN: {2}\n",
                              author, pages, IBSN);

        }
    }
}
