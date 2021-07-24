﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class HashSet
    {
        public static void HashSetOperations()
        {
            Console.WriteLine("Enter number of elements in list");
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
            HashSet<int>.Enumerator HashsetEnumerator = set.GetEnumerator();
            while(HashsetEnumerator.MoveNext())
            {
                Console.WriteLine(HashsetEnumerator.Current);
            }
        }
    }
}