using System;
namespace Goods
{
    class ListItem
    {
       const int size = 100;         Item[]list;         int listSize;
         public ListItem()         {             list = new Item[size];             listSize = 0;         }          public Item this[Item it]         {             get             {                 for (int i = 0; i < listSize; i++)                     if (list[i].Name == it.Name)                         return list[i];                 return null;             }

        }          public void putList(params Item[] it)         {             int count = it.Length;             for (int i = 0; i < count; i++)
                if (it[i] != null)                     list[listSize++] = it[i];
                         }

        public void write(){
            for (int i = 0; i < listSize; i++)
                Console.WriteLine(list[i].Name + " ");
            Console.WriteLine("All: " + listSize);
        }
  
    }
}
