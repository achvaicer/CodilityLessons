using System;
namespace CodilityLessons
{
    public class Lesson5
    {
        public Lesson5()
        {
        }

        public static int PassingCars(int[] A)
        {
            var zero = 0;
            var count = 0;

            for(var i = 0; i < A.Length; i++)
            {
                if (A[i] == 0)
                    zero++;
                else
                    count += zero;
                if (count > 1000000000) return -1;
            }
            return count;
        }
    }
}
