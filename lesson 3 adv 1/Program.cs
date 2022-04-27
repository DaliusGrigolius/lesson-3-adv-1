using System;

namespace lesson_3_adv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass<SomeIntClass> someClass = new SomeClass<SomeIntClass>();
            SomeIntClass someIntClass = new SomeIntClass(1);
            someClass.AddSomething(someIntClass);
            someClass.AddSomething(someIntClass);
            someClass.AddSomething(someIntClass);

            Console.WriteLine("------------------------------------");
            someClass.PrintAllSomethings();
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveConvertedListToArray());
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveItem(someIntClass));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.RetrieveItemOrDefaultType(someIntClass));
            Console.WriteLine("------------------------------------");
            Console.WriteLine(someClass.IsItemExists(someIntClass));
            Console.WriteLine("------------------------------------");

            Console.ReadKey();
        }
    }
}
