using System;
using System.Linq;
namespace CodilityLessons
{
    public class Lesson2
    {
        public Lesson2()
        {
        }

        public static int[] CyclicRotation(int[] A, int K)
        {

            if (A.Length == 0) return A;
            for(var k = 0; k < K; k++)
            {
                var last = A[^1];
                for (var i = A.Length - 2; i >= 0; i--)
                {
                    A[i + 1] = A[i];
                }
                A[0] = last;
                Console.WriteLine($"[{string.Join(",", A)}]");
            }
            

            return A;
        }

        public static int OddOccurrencesInArray(int[] A)
        {
            return  A.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()).First(x => x.Value % 2 == 1).Key;
        }
    }
}
// [3, 7, 9]
// [3, 3, 9]
// [3, 3, 7]
// [9, 3, 7]