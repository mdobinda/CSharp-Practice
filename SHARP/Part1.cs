using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/*
 C# Practice
Part 1
 */
namespace SHARP
{
    public class Problem1
    {
        public static IEnumerable<int> myFilter(IEnumerable<int> input)
        {
            var multipleof5 = input.Where(r => r % 5 != 0 || r <= 50);
            var cubed = multipleof5.Select(n => n * n * n);
            var oddCubed = cubed.Where(r => r % 2 != 0).ToArray();

            return oddCubed;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random(5); // Important to seed with 5 for repeatability.

            var listForProblem = Enumerable.Range(1, 100).Select(i => rnd.Next() % 101);
            var answer = Problem1.myFilter(listForProblem);

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}