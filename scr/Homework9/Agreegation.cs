using System;
using System.Linq;

namespace Homework9
{
    class Agreegation
    {
        /// <summary>
        /// Agregate Simple.
        /// </summary>
        public void Sample_Aggregate_Lambda_Simple()
        {
            var massiv = new string[] { " Alberto ", " Elza ", " Jhohan ", " Bob " };
            var result = massiv.Aggregate((a, b) =>    a + b   ).ToLower();
            Console.WriteLine(result);
        }
        /// <summary>
        /// Agreagate Seed.
        /// </summary>
        public void Sample_Aggregate_Lambda_Seed()
        {
            var numbers = new int[] { 1, 2, 3 };

            var result = numbers.Aggregate(10, (a, b) =>
            {
                return a + b;
            }
           );

            Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Console.WriteLine(result);
        }
        /// <summary>
        /// Average.
        /// </summary>
        public void Sample_Aggregate_Average()
        {
            var massiv = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = massiv.Average();
            Console.WriteLine("Massiv Average: ");
            Console.WriteLine(res);
        }
        /// <summary>
        /// Count.
        /// </summary>
        public void WorkWithCount()
        {
            var massiv = new string[] { "Alex", "Bob", "Frank", "Teckle" };
            var res = massiv.Count();
            Console.WriteLine($"Massiv count:{res}");
        }
        /// <summary>
        /// LongCount.
        /// </summary>
                // Use LongCount() when you expect the result to be greater than Int32.MaxValue()
        public void Sample_LongCount_Lambda1()
        {
            // Create array which is 5 elements larger than Int32.MaxValue
            var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

            Int64 result = largeArr.LongCount();

            Console.WriteLine("Counting largeArr elements:");
            Console.WriteLine(result);
        }

        /// <summary>
        /// Max element.
        /// </summary>
        public void Sample_Max_Lambda()
        {
            var massiv = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = massiv.Max();
            Console.WriteLine("Counting Max: ");
            Console.WriteLine(res);
        }
        /// <summary>
        /// Min.
        /// </summary>
        static void Sample_min_Element()
        {
            var massiv = new int[] { 1, 2, 3, 4, 5, 6 };
            var res = massiv.Min();
            Console.WriteLine("Couning Min");
            Console.WriteLine(res);
        }
        /// <summary>
        /// Sum elemets.
        /// </summary>
        public void Sample_Sum_Exemple()
        {
            var massiv = new int [] { 1, 2, 3, 4, 5, 6 };
            var res = massiv.Sum();
            Console.WriteLine("Sum all elements: ");
            Console.WriteLine(res);
        }



    }
}
