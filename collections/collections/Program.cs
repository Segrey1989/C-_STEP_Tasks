using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            long x1, x2; // для замера времени
            Console.WriteLine("Введите слово:");
            string word = Console.ReadLine(); // на домашнем компьютере не срабатывает
            //word устанавливается в null и дальше выбрасывается исключение при обращении



            Dictionary<string, int> dict = new Dictionary<string, int>();
            string text = File.ReadAllText(@"/Users/Siarhei/Downloads/collections/collections/Text.txt");
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '-', ')', '(', '\n' ,'\r'};
            string[] arr = text.Trim().Split(delimiterChars);

            Console.WriteLine("TESTING DICTIONARY");
            foreach (string s in arr)
                if (!dict.ContainsKey(s))
                    dict.Add(s, 1);
                else
                    dict[s] += 1;

           
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            DateTime start_dict = new DateTime();
            if (dict.ContainsKey(word) == true)
                Console.WriteLine($"Слово {word} встречается {dict[word]}");
            else
                Console.WriteLine("Данного слова нет в словаре");
            DateTime stop_dict = DateTime.Now;
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds.ToString());

            x1 = stop_dict.Ticks - start_dict.Ticks;
            Console.WriteLine(x1);
            //вывод всего словаря
            //foreach (var key in dict)
            //    Console.WriteLine(key.Key + ":" + key.Value);


            // использование списка
            // В indexOf() НАДО 
            //ПОДСТАВЛЯТЬ ЭЛЕМЕНТ СПИСКА list.indexOf(el), el - это Data, а как можно 
            //сделать поиск по list.indexOf(el.word) - по полю класса??? чтобы не писать
            //так много циклов

            Console.WriteLine("TESTING LIST");
            DateTime start_list = new DateTime();
            bool flag = false;
            List<Data> list = new List<Data>();
                list.Add(new Data(arr[0]));

            // заполнение листа, если ключа нет или инкремент значения
            for (int j = 1; j < arr.Count(); j++)
            {
                flag = false;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Word == arr[j])
                {
                    list[i].number++;
                    flag = true;
                    break;
                }
            }

                if (flag == false)
                    list.Add(new Data(arr[j]));           
            }

           
            // вывод искомого значения
            flag = false;
            for (int i = 0; i < list.Count(); i++){
                if (list[i].Word == word)
                {
                    list[i].show();
                    flag = true;
                    break;
                }
                   
            }
            if(flag == false)     
                    Console.WriteLine("No matching!");

            DateTime end_list = DateTime.Now;
            x2 = end_list.Ticks - start_list.Ticks;
            Console.WriteLine(x2);


            // определение, кто быстрее, но не показатель, т.к. в List не понятно, 
            // как искать по полю элемента
            if (x1 != 0 && x2 != 0)
            {
                if (x1 > x2)
                    Console.WriteLine($"Словарь медленнее в {x1-x2} тиков");
                else
                    Console.WriteLine($"List медленнее в {x2 - x1} тиков");
            }else{
                Console.WriteLine("Deviding by 0");
            }
            Console.ReadKey();
        }
    }
}
