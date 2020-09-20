using System;

namespace TupleDemoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is before C# 7
            Tuple<int, double, string> result = new MyTuples().Calculate();
            Console.WriteLine("This is before C# 7");
            Console.WriteLine($"Int: {result.Item1}, Double: {result.Item2}, String: {result.Item3}");

            //new line
            Console.Write(Environment.NewLine);

            //This is in C# 7 without name
            Console.WriteLine("This is in C# 7 without name");
            var result1 = new MyTuples().Calculate1();
            Console.WriteLine($"Int: {result1.Item1}, Double: {result1.Item2}, String: {result1.Item3}");

            //new line
            Console.Write(Environment.NewLine);

            //This is in C# 7 with name
            Console.WriteLine("This is in C# 7 with name");
            var result2 = new MyTuples().Calculate2();
            Console.WriteLine($"Int: {result2.intResult}, Double: {result2.doubleResult}, String: {result2.stringResult}");

            //new line
            Console.Write(Environment.NewLine);

            //This is in C# 7 with name
            Console.WriteLine("This is in C# 7 with specific name");
            var (intResult, doubleResult, stringResult) = new MyTuples().Calculate2();
            Console.WriteLine($"Int: {intResult}, Double: {doubleResult}, String: {stringResult}");
            
            Console.ReadKey();
        }

    }

    public class MyTuples
    {
        /// <summary>
        /// This is before c# 7
        /// </summary>
        /// <returns>return three values (int double, string)</returns>
        public Tuple<int, double, string> Calculate()
        {
            Tuple<int, double, string> t = Tuple.Create(10, 20.20, "Anil Kumar");
            return t;
        }

        /// <summary>
        /// this is in C# 7
        /// </summary>
        /// <returns>return three values (int double, string)</returns>
        public (int, double, string) Calculate1()
        {
            return (10, 20.20, "Anil Kumar");
        }

        /// <summary>
        /// this is in C# 7
        /// </summary>
        /// <returns>return three values (int double, string)</returns>
        public (int intResult, double doubleResult, string stringResult) Calculate2()
        {
            return (10, 20.20, "Anil Kumar");
        }
    }
}
