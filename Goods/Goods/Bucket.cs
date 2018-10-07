using System;
namespace Goods
{
        class Bucket     {         static public int size = 20;         double averageBill = 0;         Customer customer;         Item[] items;         public int sizeofBucket;         string dateOfDelivery;          public Bucket(Customer cust, string deliv)         {             customer = cust;             items = new Item[size];             sizeofBucket = 0;             dateOfDelivery = deliv;         }          public void putItem(ListItem list, params Item[] it)         {             int length = it.Length;              for (int i = 0; i < length; i++)                 if (it[i] != null)                 items[sizeofBucket++] = list[it[i]];         }          public void removeItem(Item item)         {             int i = 0;              for (i = 0; i < sizeofBucket; i++)                 if (items[i] == item)                     break;              while (i <= sizeofBucket - 1)             {                 items[i] = items[i + 1];                 i++;             }              sizeofBucket--;          }          double getPrice()         {             double summa = 0;             for (int i = 0; i < sizeofBucket; i++)                 summa += items[i].Price;                        return summa;          }

        public void makeOrder(){
            averageBill += getPrice(); 
            write();
            cleanBucket();
        } 
        void write(){
            Console.WriteLine("Заказ сформирован:\nТовары в доставке:");
            for (int i = 0; i < sizeofBucket; i++)
                if(i != sizeofBucket-1)
                    Console.Write("{0:0.00}, ", items[i].Name);
                else
                                  Console.WriteLine("{0:0.00} ", items[i].Name);

            Console.WriteLine($"Количество товаров в корзине: {sizeofBucket}");
            Console.WriteLine("Общая стоимомть товаров: {0:0.00}", getPrice());
            Console.WriteLine("Доставка произойдет {0} после 17.00," +
                              "по адресу: {1}\n", dateOfDelivery, customer.Adress);
        }
        void cleanBucket(){ sizeofBucket = 0;}
       } } 
  