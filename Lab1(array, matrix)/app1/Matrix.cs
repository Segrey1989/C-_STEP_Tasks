using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Matrix
    {
        int rows;
        int columns;
        int[,] arr;
        public Matrix(int r, int col)
        {
            rows = r;
            columns = col;
            arr = new int[rows, columns];
        }

        //заполнение случайными числами
        public void fillup()
        {
            Random kk = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    arr[i, j] = kk.Next() % 201 -100;
        }

        //вывод в консоль
        public void write()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        //поиск суммы м/у минимальным и макс значениями
        public int findSum()
        {
            int min = 0, max = 0, sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                {
                    if (arr[i, j] < min)
                        min = arr[i, j];

                    if (arr[i, j] > max)
                        max = arr[i, j];
                }

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (arr[i, j] > min && arr[i, j] < max)
                        sum += arr[i, j];
            return sum;
        }

    }
}
