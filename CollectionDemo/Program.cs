using System;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection demo!");
            Console.WriteLine("Enter 1- for List Implementation");
            //Get option from user
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    List.ListOperations();
                    break;
                default:
                    break;
            }
        }
    }
}
