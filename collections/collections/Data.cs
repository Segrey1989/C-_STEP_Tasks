using System;
namespace collections
{
    public class Data
    {
        string word;
        public int number { get; set; }
        public Data(string _word)
        {
            this.word = _word;
            this.number = 1;
        }

       public string Word
        {
            get {return word;}
            set { word = value; }
        }

        public void show(){
            Console.WriteLine($"{word}:{number}");
        }

       

    }
}
