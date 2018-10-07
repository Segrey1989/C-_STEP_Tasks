using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayD A = new ArrayD(5);
            MatrixD B = new MatrixD(3, 4);
            A.fillup();
            B.fillup();
            Console.WriteLine("A:");
            A.write();
            Console.WriteLine("B:");
            B.write();

            Console.WriteLine("min: {0:0.0}\nmax: {1:0.0}\nsumma: {2:0.0}\nmult: {3:0.0}\n" +
                              "evenSumma A: {4:0.0}\noddSumma B: {5:0.0}\n",
                              A.findMin(B), A.findMax(B), A.findSum(B), A.findMult(B), A.EvenSum(), B.oddSum() );


           // Console.WriteLine();
            Matrix arr1 = new Matrix(5, 7);
            arr1.fillup();
            arr1.write();
            Console.WriteLine("Сумма элементов массива между min max: {0}", arr1.findSum());

            Console.WriteLine("\nМассив одинаковых элементов:");
            Array array1 = new Array(4);
            Array array2 = new Array(5);
            array1.fillup();
            array2.fillup();
            Console.WriteLine("Array1:");
            array1.write();
            Console.WriteLine("\nArray2:");
            array2.write();


            Array array3 = new Array(array1.getSize());
            array3.fillTheSame(array1, array2);
            Console.WriteLine("\nArray3:");
            array3.write();

            Console.ReadKey();
        }
       
    }
}
