using System;
using System.Linq;

namespace CodilityLessons
{
    public class Lesson3
    {
        public Lesson3()
        {
        }

        public static int FrogJump(int X, int Y, int D)
        {
            return (int)Math.Ceiling( (decimal)(Y - X) / (decimal)D);
        }

        public static int FindMissingElement(int[] A)
        {
            if (A.Length == 0) return 1;
            A = A.OrderBy(x => x).ToArray();

            if (A[0] != 1) return 1;
            for(var i = 0; i < A.Length - 1; i++)
            {
                if (A[i + 1] - A[i] > 1) return A[i] + 1;
            }
            return A[A.Length - 1] + 1;
        }

        public static int TapeEquilibrium(int[] A)
        {
            if (A.Length == 0) return 0;
            if (A.Length == 1) return Math.Abs(A[0]);
            var sum = A.Sum();
            var min = int.MaxValue;
            var f = 0;
            var s = sum;
            for(var i = 0; i < A.Length; i++)
            {
                var a = A[i];
                f += a;
                s -= a;
                min = Math.Min(Math.Abs(f - s), min);
            }
            return min;
        }

        public static int FrogRiverOne(int X, int[] A)
        {
            var passedX = false;
            var passedC = false;
            var completed = new String('1', X);
            var counting = new String('0', X);
            for(var i = 0; i <  A.Length; i++)
            {
                var start = A[i] > 0 ? counting.Substring(0, A[i] - 1) : "";
                var end = A[i] < A.Length - 2 ? counting.Substring(A[i]) : "";
                counting = start + "1" + end;
                if (A[i] == X) passedX = true;
                if (i >= X - 1) passedC = true;
                if (passedX && passedC && counting == completed) return i;
            }
            return -1;
        }
    }

}
