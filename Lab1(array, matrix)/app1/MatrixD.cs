using System;
namespace app1
{
    public class MatrixD
    {

        int rows;
        int columns;
        double[,] arr;
        public MatrixD(int r, int col)
        {
            rows = r;
            columns = col;
            arr = new double[rows, columns];
        }

        public int getRows() {return rows;}
        public int getCols(){return columns;}
        public double getEl(int r, int c){return arr[r,c];}

        public void fillup()
        {
            Random kk = new Random();
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    arr[i, j] = kk.NextDouble() * 10 %20;
        }

        public void write()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    Console.Write("{0:0.0} ", arr[i, j]);
                Console.WriteLine();
            }
        }

        public double findSum()
        {
            double min = 0, max = 0, sum = 0;
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

        // сумма всех нечетных элементов
        public double oddSum()
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    if (j % 2 != 0)
                        sum += arr[i, j];
            return sum;
        }
    }
}
