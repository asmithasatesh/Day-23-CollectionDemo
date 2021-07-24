using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class Queue
    {
        public static void QueueOperations()
        {
            Console.WriteLine("Enter number of elements in Queue");
            int number = Convert.ToInt32(Console.ReadLine());
            string input;
            //Create Queue
            Queue<string> queue = new Queue<string>();
            // Inserting elements in Queue
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter number {0}:", i + 1);
                input = Console.ReadLine();
                queue.Enqueue(input);
            }

            //Display Queue
            Console.WriteLine("\n*****Displaying Queue items*****");
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

            //Dequeue First Element
            string removedElement=queue.Dequeue();
            Console.WriteLine("Removed Element is: {0}", removedElement);

            //Display Queue using enumerator after Dequeue
            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
