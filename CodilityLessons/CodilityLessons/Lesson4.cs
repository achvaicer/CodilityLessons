using System;
using System.Linq;

namespace CodilityLessons
{
    public class Lesson4
    {
        public Lesson4()
        {
        }

        public static int FrogRiverOne(int X, int[] A)
        {
            var passedX = false;
            var passedC = false;
            var completed = new String('1', X);
            var counting = new String('0', X);
            for (var i = 0; i < A.Length; i++)
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

        public static int PermCheck(int[] A)
        {
            if (A.Length == 0) return 1;
            A = A.OrderBy(x => x).ToArray();

            if (A[0] != 1) return 0;
            for (var i = 0; i < A.Length - 1; i++)
            {
                if (A[i + 1] - A[i] > 1) return 0;
            }
            return A[A.Length - 1] == A.Length ? 1 : 0;
        }

        public static int CountDiv(int A, int B, int K)
        {
            var count = (A % K == 0 || B % K == 0) ? 1 : 0;
            return (A >= K) ?
                count + (B - A) / K :
                count + B / K;
        }
    }
}
