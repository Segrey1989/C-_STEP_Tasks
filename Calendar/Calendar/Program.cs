using System;
using userDate;
using System.Windows.Forms;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            myDate date1 = new myDate(2018, 10, 1);
            myDate date2 = new myDate(2018, 12, 1);

            Console.WriteLine("Вычитание дат:");
            int days = date2 -date1;
            Console.WriteLine(days);

            Console.WriteLine("Прибавление дней к дате:");
            date1 = date1 + 34;
            date1.writeDate();
           
            Console.WriteLine("Преобразование к DateTime:");
            DateTime time = (DateTime)date1;
            Console.WriteLine(time);

            Console.WriteLine("Сравнение:");
            Console.WriteLine(date2 < date1);
            Console.WriteLine(date2 > date1);
            Console.WriteLine(date2 == date1);
            Console.WriteLine(date2 != date1);

           
            //странно, в конструкторе определено исключение для таких случаев,
            // ожидалась генерация исключения
                //myDate wrongDate = new myDate(2018, 12, 41);

            Console.ReadLine();
        }

      
    }
}

