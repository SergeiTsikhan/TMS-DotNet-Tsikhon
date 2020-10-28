using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
//AsEnumerable: приводит коллекцию к IEnumerable того же типа.
//Этот образец лямбда-выражения приводит массив строк к соответствующему IEnumerable.
    class Conversion
    {
        /// <summary>
        /// AsEnumerable.
        /// </summary>
        public void Sample_AsEnumerable_Lambda()
        {
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Console.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Console.WriteLine(name);
        }
        /// <summary>
        /// Cast.
        /// </summary>
        // Note: The source we're casting from must contain only elements of the same type.
        public void Sample_Cast_Linq()
        {
            List<string> vegetables = new List<string> { "Cucumber", "Tomato", "Broccoli" };

            var result = from v in vegetables.Cast<string>()
                         select v;

            Console.WriteLine("List of vegetables casted to a simple string array:");
            foreach (string vegetable in result)
                Console.WriteLine(vegetable);
        }
        /// <summary>
        /// OfType.
        /// </summary>
        public void Sample_OfType_Linq()
        {
            object[] objects = { "Thomas", 31, 5.02, null, "Joey" };

            var result = from o in objects.OfType<string>()
                         select o;

            Console.WriteLine("Objects being of type string:");
            foreach (string str in result)
                Console.WriteLine(str);
        }
        /// <summary>
        /// ToArray.
        /// </summary>
        public void Sample_ToArray_Linq()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = from n in numbers.ToArray<int>() select n;

            Console.WriteLine("New array contains identical values:");
            foreach (int number in result)
                Console.WriteLine(number);
        }
        /// <summary>
        /// ToDictionary (simple).
        /// </summary>


        /// <summary>
        /// ToDictionary.
        /// </summary>
        public void Sample_ToDictionary_Linq_Conditional()
        {
            int[] numbers = { 1, 2, 3, 4 };

            var result = from n in numbers.ToDictionary(k => k, v => (v % 2) == 1 ? "Odd" : "Even")
                         select n;

            Console.WriteLine("Numbers labeled Odd and Even in dictionary:");
            foreach (var dic in result)
                Console.WriteLine("Value {0} is {1}", dic.Key, dic.Value);
        }
        /// <summary>
        /// ToList.
        /// </summary>
        public void Sample_ToList_Lambda()
        {
            string[] names = { "Brenda", "Carl", "Finn" };

            List<string> result = names.ToList();

            Console.WriteLine(String.Format("names is of type: {0}", names.GetType().Name));
            Console.WriteLine(String.Format("result is of type: {0}", result.GetType().Name));
        }
        /// <summary>
        /// ToLookup.
        /// </summary>
        static void Sample_ToLookup_Lambda()
        {
            string[] words = { "one", "two", "three", "four", "five", "six", "seven" };

            var result = words.ToLookup(w => w.Length);

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(String.Format("Elements with a length of {0}:", i));
                foreach (string word in result[i])
                    Console.WriteLine(word);
            }
        }

    }
}
