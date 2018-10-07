using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userDate
{
    public class myDate
    {
        int year;
        int month;
        int day;

       // содержатся месяцы с разным количеством дней
        static int[] thirty = new int[4] {4, 6, 9, 11};
        static int[] thirtyOne = new int[7] {1,3,5,7,8,10,12};

        public int getDay() { return day; }
        public int getMonth() { return month; }
        public int getYear() { return year; }


        public myDate()
        {
            year = 2018;
            month = 09;
            day =12;        
        }
        public myDate(int _year,  int _month, int _day )
        {
            try
            {
                if (_year < 0) throw new WrongValue("Только от Р.Х");
                year = _year;
               
                if (_month < 1 || _month > 12) throw new WrongValue("Некорректный месяц");
                month = _month;
                if(inArray(month, thirty) == true && _day > 30 || _day < 1) throw new WrongValue("Некорректный день");
                if (inArray(month, thirtyOne) == true && _day > 31 || _day < 1) throw new WrongValue("Некорректный день");
                if(year % 400 == 0 && month == 2 && _day > 29  || _day < 1) throw new WrongValue($"Некорректный день. {year} - високосный год");
                if (year % 400 != 0 && month == 2 && _day > 28 || _day < 1) throw new WrongValue("Некорректный день");
                day = _day;
            }
            catch(WrongValue ex)
            {
                MessageBox.Show(ex.Message);
               // Console.WriteLine(ex.Message);
            }
        }

        // проверяет сколько дней в месяце
        static bool inArray(int num, int[] arr)
        {
            foreach(int value in arr)        
                if (value == num)
                    return true;
            return false;
        }

        //вывод
        public void writeDate()
        {
            Console.WriteLine("{0}.{1}.{2}", day, month, year);
        }


       // прибавление дней к дате
        public static myDate operator +(myDate date, int num)
        {

            while (num != 0)
            {
                date++;
                num--;
            }
            return date;
        }
      
        // инкремент
        public static myDate operator++(myDate date){
            int month = date.getMonth();
            int day = date.getDay();
            int year = date.getYear();
            day++;
            if(day > 30 && (inArray(month, thirty) == true)){
                day = day - 30;
                month += 1;
            }
            else if (day > 31 && inArray(month, thirtyOne) == true)
            {
                day = day - 31;
                month = month + 1;
            }
            else
            {
                if (year % 400 == 0 && day > 29 && month == 2)
                {
                    day -= 29;
                    month++;
                }
                else if (day > 28 && month == 2)
                {
                    day -= 28;
                    month++;
                }
            }

            if (month > 12)
            {
                month = month - 12;
                year++;

            }
            return new myDate(year, month, day);
        }


        // декремент
        public static myDate operator--(myDate date){
            int month = date.getMonth();
            int day = date.getDay();
            int year = date.getYear();
            day--;
            if (day < 1)
            {
                int prev_month = month - 1;
                if (prev_month < 1)
                    prev_month = 12;

                if ((inArray(prev_month, thirty) == true))
                {
                    day = 30 - day;
                    month -= 1;
                }

                else if (inArray(prev_month, thirtyOne) == true)
                {
                    day = 31 - day;
                    month = month - 1;
                }
                else
                {
                    if (year % 400 == 0 && prev_month == 2)
                    {
                        day = 29 - day;
                        month--;
                    }
                    else if (prev_month == 2)
                    {
                        day = 28- day;
                        month--;
                    }
                }

                if (month < 1 )
                {
                    month = 12;
                    year--;

                }
            }
            return new myDate(year, month, day);
        }


        // вычитание дней из даты
        public static myDate operator-(myDate date, int num){
            while(num != 0){
                date--;
                num--;
            }
            return date;
        }


        // равенство
        public static bool operator==(myDate date1, myDate date2){
            return (date1.getYear() == date2.getYear() &&
                    date1.getMonth() == date2.getMonth() &&
                    date1.getDay() == date2.getDay()) ? true : false;
        }

        public static bool operator !=(myDate date1, myDate date2){
            return !(date1 == date2);
        }

        //больше
        public static bool operator >(myDate date1, myDate date2)
        {
            if (date1.getYear() > date2.getYear())return true;
            if (date1.getMonth() > date2.getMonth()) return true;
            if (date1.getDay() > date2.getDay()) return true;
            return false;
        }

        // меньше
        public static bool operator <(myDate date1, myDate date2)
        {
            return !(date1 > date2);
        }


        // вычитание дат
        public static int operator -(myDate date1, myDate date2){

            //Не работает этот блок, чтобы от меньшей даты можно было отнять большую
            //пучему так нельзя обменять значения объектов???

            //if(date1 < date2){

            //    myDate tmp = date1;
            //    date1 = date2;
            //    date2 = tmp;
            //    date1.writeDate();
            //    date2.writeDate();
            //}

            //и так не работает
            // смысл в том, что хочется отнимать даты вне зависимости от того какая больше
           // myDate small, big;
           //big =  date1 > date2 ? date1 : date2;
            //small = date1 < date2 ? date1 : date2;
            //while (big != small)
            //{
            //    big--;
            //    count++;
            //}

            //простой способ
            myDate final_date = date1;//new myDate(year1, month1, day1);
            int count = 0;
            while (final_date != date2)
            {
                final_date--;
                count++;
            }

         

            // сложный способ
            //int month1 = date1.getMonth();
            //int day1 = date1.getDay();
            //int year1 = date1.getYear();


            //int month2 = date2.getMonth();
            //int day2 = date2.getDay();
            //int year2 = date2.getYear();

            //int all_days = 0;
            //int days1 = day1;
            //int days2 = 0;

            //if (year2 < year1){
            //if (inArray(month2, thirty) == true)
            //    days2 = 30 - day2;
            //else if (inArray(month2, thirtyOne) == true)
            //    days2 = 31 - day2;
                    
            // подсчитываем дни от текущей даты до 1 января текущего года
            //while(month1-1 > 0){
            //    if (inArray(month1, thirty) == true)
            //                days1 += 30;
            //    else if (inArray(month1, thirtyOne) == true)
            //        days1 += 31;
            //    else
            //    {
            //        if (year1 % 400 == 0 && month1 == 2)
            //            days1 += 29;
            //        else if (month1 == 2)
            //            days1 += 28;
            //    }     
            //    month1--;
                   
            //}

            // подсчитываем дни от  даты до 1 января следующего года
            //while (month2 + 1 <= 12)
            //{
            //    if (inArray(month2, thirty) == true)
            //        days2 += 30;
            //    else if (inArray(month2, thirtyOne) == true)
            //        days2 += 31;
            //    else
            //    {
            //        if (year2 % 400 == 0 && month2 == 2)
            //            days2 += 29;
            //        else if (month2 == 2)
            //            days2 += 28;
            //    }
            //    month2++;                
            //}

            // берем в расчет полные годы между 2мя датами и високосные годы
            //    all_days = days1 + days2;
            //    int years = year1 - (year2+1);
            //    all_days += years * 365;
            //    for (int i = year1 - 1; i > year2; i--)
            //        if (i % 400 == 0)
            //            all_days++;
            //}
            // return all_days;
           
            return count;
                
        }

        // явное преобразование
        public static explicit operator DateTime(myDate date){
            return new DateTime(date.getYear(), date.getMonth(), date.getDay());
        }

        //public static implicit operator DateTime(myDate date)
        //{
        //    return new DateTime(date.getYear(), date.getMonth(), date.getDay());
        //}
   
    }
}

// Не работает implicit  operator DateTime?