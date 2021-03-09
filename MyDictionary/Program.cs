using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> languages = new Dictionary<int, string>();
            languages.Add(1, "English");
            languages.Add(2, "Turkish");
            languages.Add(3, "German");
            Console.WriteLine("Dictionary Counter: " + languages.Count);
            Console.WriteLine();
            Console.WriteLine("Content of the dictionary: ");

            foreach (KeyValuePair<int, string> kvp in languages)
            {
                Console.WriteLine("ID: " + kvp.Key + " Language: " + kvp.Value);
            }

            Console.WriteLine();

            MyDictionary<int, string> myLanguages = new MyDictionary<int, string>();
            myLanguages.Add(1, "English");
            myLanguages.Add(2, "Turkish");
            myLanguages.Add(3, "German");
            Console.WriteLine("MyDictionary - Key Counter: " + myLanguages.MyKeysLength);
            Console.WriteLine("MyDictionary - Value Counter: " + myLanguages.MyValuesLength);
            Console.WriteLine();
            Console.WriteLine("Content of the dictionary: ");

            myLanguages.ShowData();
        }
    }
}
