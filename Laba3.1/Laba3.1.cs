using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;

namespace Laba3._1
{
    class Program
    {
        static void Main()
        {
            Stopwatch sw = new Stopwatch();
            Console.Write("Enter amount of people: ");
            Int32 amount = Convert.ToInt32(Console.ReadLine());

            sw.Start();
            ArrayList round1 = new ArrayList(amount);
            for (int i = 0; i < amount; i++)
            {
                round1.Add(new Person() { number = i + 1 });
            }
            Console.WriteLine($"The last number ArrayList: {Count(round1).number}");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            sw.Reset();


            sw.Start();
            LinkedList<Person> round2 = new LinkedList<Person>();
            for (int i = 0; i < amount; i++)
            {
                round2.AddLast(new Person() { number = i + 1 });
            }
            Console.WriteLine($"The last number LinkedList: {Count(round2).number}");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + "ms");
            sw.Reset();
            Console.ReadKey();
        }
        static public Person Count(ArrayList list)
        {
            Int32 i = 1;
            while (list.Count != 1)
            {
                list.RemoveAt(i);
                i++;
                if (i > list.Count - 1)
                {
                    i = i - list.Count;

                }
            }
            return (Person)list[0];
        }
        static public Person Count(LinkedList<Person> list)
        {
            Int32 i = 1;
            while (list.Count != 1)
            {
                list.Remove(NodeNumber(list, i));
                i++;
                if (i > list.Count - 1)
                {
                    i = i - list.Count;

                }
            }
            return list.First.Value;
        }
        static public LinkedListNode<Person> NodeNumber(LinkedList<Person> list, Int32 num)
        {
            LinkedListNode<Person> node = list.First;
            if (num == 0)
            {
                return list.First;
            }
            for (int i = 0; i < num; i++)
            {
                node = node.Next;
            }
            return node;
        }
    }
    class Person
    {
        public Int32 number;
    }
}