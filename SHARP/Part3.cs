using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



/*
 C# Practice
Part 3
 */
namespace SHARP
{
    public class TestProblem3
    {
        public static IEnumerable<int> merge(IEnumerable<int> input1, IEnumerable<int> input2, IEnumerable<int> input3, IEnumerable<int> input4)
        {
            IEnumerable<int> sample, s2, s3, s4, s5;

            sample = input1;
            s2 = input1.Where(r => r % 10 == 0);
            s3 = input2.Where(r => r % 10 == 0);
            s4 = input3.Where(r => r % 10 == 0);
            s5 = input4.Where(r => r % 10 == 0);

            sample = input1.Intersect(s2);
            sample = sample.Intersect(s3);
            sample = sample.Intersect(s4);
            sample = sample.Intersect(s5);


            return sample;
        }
    }

    public class Program3
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            var list1 = Enumerable.Range(1, 15).Select(i => rnd.Next() % 16);
            var list2 = Enumerable.Range(2, 42).Select(i => rnd.Next() % 42).Where(r => r % 2 == 0);
            var list3 = Enumerable.Range(3, 21).Select(i => rnd.Next() % 22).Where(r => r % 2 != 0);
            var list4 = Enumerable.Range(5, 105).Select(i => rnd.Next() % 106).Where(r => r % 5 == 0);
            var answer = TestProblem3.merge(list1, list2, list3, list4);

            foreach (int i in answer)
            {
                Console.WriteLine(i);
            }
        }
    }
}

