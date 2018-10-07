using System;
using System.Threading;


namespace app1
{
    
    class Array
    {
        int size;
        int[] arr;

        public Array(int s) {
            size = s;
            arr = new int[size];
        }

        //заполнение случайными числами
        public void fillup()
        {
            Thread.Sleep(20);
            Random kk = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = kk.Next() % 21 - 10;
        }

        //вывод в консоль
        public void write()
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");

        }

       
        public int getSize() { return size; }
        public int getEl(int index) {
            return   arr[index];
        }

        // частный метод перевыделения памяти
        int[] resize(int[] array,int num)
        {
            int[] tmp = new int[num];
            for (int i = 0; i < num; i++)
                tmp[i] = array[i];
            return tmp;

        }

        // поиск одинаковых элементов двух массивов и заись их в третий
        public void fillTheSame(Array ar1, Array ar2)
        {
            int ind = 0;
            for(int i =0; i < ar1.getSize(); i++)
                for (int j = 0; j < ar2.getSize(); j++)
                    if(ar1.getEl(i) == ar2.getEl(j))
                    {
                        arr[ind++] = ar1.getEl(i);
                        break;
                    }
           arr = resize(arr, ind);
            size = ind;
            
        }


        }
    }

