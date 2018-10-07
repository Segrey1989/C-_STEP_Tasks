using System;
namespace Items
{
   
    public class Bucket
    {
        static int size = 20;
        ItemBasic[] array = new ItemBasic[size];
        int itemCount;
       
        public Bucket(){
            itemCount = 0;
          
        }

      
        public void putItem(ItemBasic item)
        {
            array[itemCount++] = item;
        }

        public void removeItem(ItemBasic item){
            int i = 0;

            for (i = 0; i < itemCount; i++)
                if (array[i] == item)
                    break;
           
            while (i <= itemCount - 1)
            {
                array[i] = array[i + 1];
                i++;
            }    
            
            itemCount--;

        }

        public double getSumma(){
            double summa = 0;
            for (int i = 0; i < itemCount; i++)
                summa += array[i].getCost();
            return summa;
        }

        public int getItemsNum() { return itemCount; }

        public void show(){
            Console.WriteLine("Содержимое корзины:");
            for (int i = 0; i < itemCount; i++)
                if(i == itemCount-1)
                    Console.Write(array[i].getName());
                else
                    Console.Write(array[i].getName() + ", ");
            Console.WriteLine();
            
        }
            
    }
}
