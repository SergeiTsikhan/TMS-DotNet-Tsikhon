using System;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            Agregation();
            Conversion();


        }
        public static void Agregation()
        {
            var Agregation1 = new Agreegation();
            Agregation1.Sample_Aggregate_Lambda_Simple();
            Console.WriteLine("==========");
            Agregation1.Sample_Aggregate_Lambda_Seed();
            Console.WriteLine("==========");
            Agregation1.Sample_Aggregate_Average();
            Console.WriteLine("==========");
            Agregation1.WorkWithCount();
            Console.WriteLine("==========");
            //Agregation1.Sample_LongCount_Lambda1();
            Console.WriteLine("==========");
            Agregation1.Sample_Max_Lambda();
            Console.WriteLine("==========");
            Agregation1.Sample_Sum_Exemple();
            Console.WriteLine("END");
        }
        public static void Conversion()
        {
            Console.WriteLine("==========");
            Console.WriteLine("==========");
            Console.WriteLine("New");
            Console.WriteLine("==========");
            var Agregation1 = new Conversion();
            Agregation1.Sample_AsEnumerable_Lambda();
            Console.WriteLine("==========");
            Console.WriteLine("==========");
            Agregation1.Sample_Cast_Linq();
            Console.WriteLine("==========");
            Agregation1.Sample_OfType_Linq();
            Console.WriteLine("==========");
            Agregation1.Sample_ToArray_Linq();
            Console.WriteLine("==========");
            Agregation1.Sample_ToDictionary_Linq_Conditional();
            Console.WriteLine("==========");
            Agregation1.Sample_ToList_Lambda();
        }
    }
}
