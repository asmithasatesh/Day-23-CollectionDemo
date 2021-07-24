using System;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection demo!");
            Console.WriteLine("Enter 1- for List Implementation");
            Console.WriteLine("Enter 2- for HashSet Implementation");
            Console.WriteLine("Enter 3- for Queue Implementation");
            Console.WriteLine("Enter 4- for Stack Implementation");
            Console.WriteLine("Enter 5- for Dictionary Implementation");
            //Get option from user
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    List.ListOperations();
                    break;
                case 2:
                    HashSet.HashSetOperations();
                    break;
                case 3:
                    Queue.QueueOperations();
                    break;
                case 4:
                    Stack.StackOperations();
                    break;
                case 5:
                    Dictionary.DictionaryOperations();
                    break;
                default:
                    break;
            }
        }
    }
}
