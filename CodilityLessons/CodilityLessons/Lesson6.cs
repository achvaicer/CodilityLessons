using System.Collections.Generic;

namespace CodilityLessons
{
    public class Lesson6
    {
        public Lesson6()
        {
        }

        public static int Distinct(int[] A)
        {
            var dictionary = new Dictionary<int, int>();

            for(var i = 0; i < A.Length; i++)
            {
                if (dictionary.ContainsKey(A[i]))
                    dictionary.Add(A[i], 1);
                else
                    dictionary[A[i]] += 1;
            }
            return dictionary.Keys.Count;
        }
    }
}
