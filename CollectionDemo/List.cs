using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class List
    {
        public static void ListOperations()
        {
            Console.WriteLine("Enter number of elements in list");
            //Create a list of integers
            List<int> list = new List<int>();
            int number = Convert.ToInt32(Console.ReadLine());
            int input;
            for(int i=0;i<number;i++)
            {
                Console.WriteLine("Enter number {0}:",i+1);
                input = Convert.ToInt32(Console.ReadLine());
                list.Add(input);
            }

            //Display Elements of List
            Console.WriteLine("\n*****Displaying List items*****");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
        } 
    }
}
