using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class HashSet
    {
        public static void HashSetOperations()
        {
            Console.WriteLine("Enter number of elements in HashSet");
            int number = Convert.ToInt32(Console.ReadLine());
            int input;
            // Creating a HashSet of integer
            HashSet<int> set = new HashSet<int>();

            // Inserting elements in HashSet
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                input = Convert.ToInt32(Console.ReadLine());
                set.Add(input);
            }

            //Display HashSet
            Console.WriteLine("\n*****Displaying Hash Set items*****");
            HashSet<int>.Enumerator HashsetEnumerator = set.GetEnumerator();
            while(HashsetEnumerator.MoveNext())
            {
                Console.WriteLine(HashsetEnumerator.Current);
            }
        }
    }
}
