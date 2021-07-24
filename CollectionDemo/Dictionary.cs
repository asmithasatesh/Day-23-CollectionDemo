using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionDemo
{
    class Dictionary
    {
        public static void DictionaryOperations()
        {
            Console.WriteLine("Enter number of elements in Dictionary");
            int number = Convert.ToInt32(Console.ReadLine());
            string input;
            //Create a Dictionary of string
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter element {0}:", i + 1);
                input = Console.ReadLine();
                keyValuePairs.Add(i+1,input);
            }

            //Access Value using Key
            Console.WriteLine("\nValue for key 1 is: {0}",keyValuePairs[1]);

            //Display Elements of Dictionary
            Console.WriteLine("\n*****Displaying Dictionary items*****");
            foreach (var i in keyValuePairs)
            {
                Console.WriteLine("Key: {0}  Value: {1}",i.Key,i.Value);
            }
        }
    }
}
