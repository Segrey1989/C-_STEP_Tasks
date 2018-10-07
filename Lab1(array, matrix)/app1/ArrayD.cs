using System;
using System.Threading;
namespace app1
{
    class ArrayD
    {

        int size;
        double[] arr;

        public ArrayD(int s)
        {
            size = s;
            arr = new double[size];
        }

        //заполнение случайными числами
        public void fillup() {
            Thread.Sleep(20);
            Random kk = new Random();
            for (int i = 0; i < size; i++)
                arr[i] = kk.NextDouble()*10 % 10;
        }

        //вывод в консоль
        public void write()
        {
            for (int i = 0; i < size; i++)
                Console.Write("{0:0.0} ", arr[i]);
            Console.WriteLine();

        }


        public int getSize() {return size; }
        public double getEl(int index) {return arr[index]; }
          
        // поиск минимального значения
            public double findMin(MatrixD mtx){
                double min = arr[0];
                for (int i = 1; i < size; i++)
                    if (arr[i] < min)
                        min = arr[i];

                for (int i = 0; i < mtx.getRows(); i++)
                for (int j = 0; j < mtx.getCols(); j++)
                    if (mtx.getEl(i,j) < min)
                        min = mtx.getEl(i, j);
            return min;
        }

        // поиск максимального значения
        public double findMax(MatrixD mtx)
        {
            double max = arr[0];
            for (int i = 1; i < size; i++)
                if (arr[i] > max)
                    max = arr[i];

            for (int i = 0; i < mtx.getRows(); i++)
                for (int j = 0; j < mtx.getCols(); j++)
                    if (mtx.getEl(i, j) > max)
                        max = mtx.getEl(i, j);
            return max;
        }


        // поиск суммы элементов двух массивов
            public double findSum(MatrixD mtx)
        {
            double sum = 0;
            for (int i = 0; i < size; i++)
                sum += arr[i];

            for (int i = 0; i < mtx.getRows(); i++)
                for (int j = 0; j < mtx.getCols(); j++)
                        sum += mtx.getEl(i, j);
            return sum;
        }

        // поиск произведения элементов двух массивов
        public double findMult(MatrixD mtx)
        {
            double mult = 1;
            for (int i = 0; i < size; i++)
                mult *= arr[i];

            for (int i = 0; i < mtx.getRows(); i++)
                for (int j = 0; j < mtx.getCols(); j++)
                    mult *= mtx.getEl(i, j);
            return mult;
        }

        // поиск суммы четных элементов
        public double EvenSum(){
            double sum = 0;
            for (int i = 0; i < size; i++)
                if (i % 2 == 0)
                    sum += arr[i];
            return sum;
        }

    }
}
