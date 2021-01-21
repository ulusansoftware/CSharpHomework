using System;
using System.Collections.Generic;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> bookDatabase = new Dictionary<int, string>();
            bookDatabase.Add(130, "Satranç");
            bookDatabase.Add(345 ,"Şeker Portakalı");

            Dictionary<int, string>.KeyCollection ValueList = bookDatabase.Keys;
            foreach(KeyValuePair<int, string> item in bookDatabase)
            {
                Console.WriteLine("PageNumber: {0} , BookName: {1}", item.Key,item.Value);
            }
            Console.ReadLine();
        }
    }
}