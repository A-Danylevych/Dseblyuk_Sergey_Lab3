using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //var newarr = from i in Massiv.SetArray()
            //             where i / 10 >= 1 && i / 10 < 10 && i > 0
            //             select i;
            var newarr = Massiv.SetArray().Where(i => i / 10 >= 1 && i / 10 < 10 && i > 0);
            int count = default;
            double average = default;
            if (newarr.Count() != 0)
            {
                count = newarr.Count();
                average = newarr.Average();
            }
            foreach (var item in newarr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Count of new collection: {count}");
            Console.WriteLine($"Average number of new collection: {average}");
            Console.ReadKey();
        }
    }
    class Massiv
    {
        static Random rnd = new Random();
        static int amount = rnd.Next(10, 30);
        public static List<int> arr = new List<int>();
        public static List<int> SetArray()
        {
            for (int i = 0; i < amount; i++)
            {
                arr.Add(rnd.Next(0, 200));
            }
            return arr;
        }
    }
}
