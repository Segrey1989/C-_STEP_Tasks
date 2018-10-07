using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_classes_
{
    class Bucket
    {
        static public int size = 20;
        double averageBill = 0;
        Customer customer;
        Item[] items;
        int sizeofBucket;
        string dateOfDelivery;

        public Bucket(Customer cust, string deliv)
        {
            customer = cust;
            items = new Item[size];
            sizeofBucket = 0;
            dateOfDelivery = deliv;
        }

        public void putItem(ListItem list, params Item[] it)
        {
            int length = it.Length;

            for (int i = 0; i < length; i++)
            if (list[it[i]] != null)
                items[sizeofBucket++] = list[it[i]];
        }

        public void removeItem(Item item)
        {
            int i = 0;

            for (i = 0; i < sizeofBucket; i++)
                if (items[i] == item)
                    break;

            while (i <= sizeofBucket - 1)
            {
                items[i] = items[i + 1];
                i++;
            }

            sizeofBucket--;

        }

        public double getPrice()
        {
            double summa = 0;
            for (int i = 0; i < sizeofBucket; i++)
                summa += items[i].getPrice();
            averageBill += summa; 
            return summa;

        }

       void clean()
        {
            sizeofBucket = 0;

        }


    }
}
