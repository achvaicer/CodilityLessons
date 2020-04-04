using System;
using System.Linq;

namespace CodilityLessons
{
    public class Lesson1
    {
        public Lesson1()
        {
           

        }

        public static int BinaryGap(int N)
        {
            var binary = Convert.ToString(N, 2);

            var zeros = binary.Split(new[] { '1' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            if (zeros.Count == 0 || (zeros.Count == 1 && binary.Last() == '0')) return 0;
            if (binary.Last() == 0)
                zeros = zeros.Take(zeros.Count - 1).ToList();

            return zeros.Max().Length;
        }
    }
}
