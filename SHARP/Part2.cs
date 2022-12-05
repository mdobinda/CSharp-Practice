using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*
 C# Practice
Part 2
 */
namespace SHARP
{
    public class Problem2
    {
        public static IEnumerable<int> myFilter(IEnumerable<int> input)
        {
            var multiplesof6 = input.Where(r => r % 6 != 0 || r < 42);
            var squared = multiplesof6.Select(n => n * n);
            var evenSquared = squared.Where(r => r % 2 == 0).ToArray();

            return evenSquared;
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            var listForProblem = Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);
            var answer = Problem2.myFilter(listForProblem);

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}

