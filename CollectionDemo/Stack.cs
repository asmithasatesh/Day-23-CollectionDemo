using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class Stack
    {
        public static void StackOperations()
        {
            Console.WriteLine("Enter number of elements in Stack");
            int number = Convert.ToInt32(Console.ReadLine());
            string input;
            //Create Stack
            Stack<string> stack = new Stack<string>();
            // Inserting elements in Stack
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                input = Console.ReadLine();
                stack.Push(input);
            }

            //Display Queue
            Console.WriteLine("\n*****Displaying Stackitems*****");
            foreach (var i in stack)
            {
                Console.WriteLine(i);
            }

            //Dequeue Top/Last Element
            string removedElement = stack.Pop();
            Console.WriteLine("Removed Element is: {0}", removedElement);

            //Display Stack using enumerator after Pop
            Stack<string>.Enumerator enumerator = stack.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
