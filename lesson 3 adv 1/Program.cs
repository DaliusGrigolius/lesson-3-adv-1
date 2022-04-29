using System;

namespace lesson_3_adv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass<int> someClass = new SomeClass<int>();
            someClass.AddSomething(1);
            someClass.AddSomething(2);
            someClass.AddSomething(3);

            Console.WriteLine("------------------------------------");
            someClass.PrintAllSomethings();
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveConvertedListToArray());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveItem(1));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveItemOrDefaultType(2));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.IsItemExists(3));
            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }
    }
}
