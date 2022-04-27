using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_3_adv_1
{
    public class SomeClass<T>
    {
        private List<T> ListOfSomething { get; set; }

        public SomeClass()
        {
            ListOfSomething = new List<T>();
        }

        public void PrintAllSomethings()
        {
            foreach (var something in ListOfSomething)
            {
                Console.WriteLine(something);
            }
        }

        public T[] RetrieveConvertedListToArray()
        {
            return ListOfSomething.ToArray();
        }

        public T RetrieveItem(T item)
        {
            try
            {
                return ListOfSomething.Single(i => i.Equals(item));
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine($"upsyyyy: {e.Message}");
            }
            return item;
        }

        public T RetrieveItemOrDefaultType(T item)
        {
            try
            {
                return ListOfSomething.SingleOrDefault(i => i.Equals(item));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"upsyyyy: {e.Message}");
            }
            return item;
        }

        public bool IsItemExists(T item)
        {
            return ListOfSomething.Contains(item);
        }

        public void AddSomething(T something)
        {
            ListOfSomething.Add(something);
        }
    }
}
