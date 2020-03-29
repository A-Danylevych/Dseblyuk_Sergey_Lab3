using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Laba3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Int32 amount = 5;

            Dictionary<Int32, Int32> dict = new Dictionary<Int32, Int32>();
            Dictionary<Int32, Int32> newdict = new Dictionary<Int32, Int32>();
            List<Int32> keys = new List<Int32>();
            for (int i = 0; i < amount; i++)
            {
                dict[i] = rnd.Next(1, 6);
                newdict[i] = rnd.Next(1, 6);
                Console.WriteLine(i + "-" + dict[i]);
            }


            for (int key = 0; key < amount; key++)
            {
                int value = 0;
                for (int key2 = 0; key2 < amount; key2++)
                {
                    if (dict[key] == dict[key2])
                    {
                        keys.Add(key2);
                        value++;
                    }
                }
                foreach (var key3 in keys)
                {
                    newdict[key3] = value;
                }
                keys.Clear();
            }


            Console.WriteLine(new string('-', 20));
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(i + "-" + newdict[i]);
            }

            string jsonString = JsonConvert.SerializeObject(newdict);
            Console.WriteLine(jsonString);
            string path = "D:/C#/VisualStudio/Projects/Laba3.2/Read.json";
            File.WriteAllText(path, jsonString);
            Console.ReadKey();
        }
    }
}
