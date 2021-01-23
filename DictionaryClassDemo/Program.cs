using System;

namespace DictionaryClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Meral");
            names.Add("Ayşe");
            names.Add("Sümeyye");
            names.Add("Şevval");
            names.Add("Kadriye");

            Console.WriteLine(names.Count);
            

        }


    }


}
