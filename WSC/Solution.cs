using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSC
{
    class Solution
    {
        public int solution(int A, int B)
        {
            int count = 0;
            int a = (A > -1) ? (int)Math.Floor(Math.Sqrt(A)) : A;
            for (; a <= B; a++)
            {
                if (Math.Pow(a, 2) <= B && Math.Pow(a, 2) >= A)
                    count++;                    
            }
            return count;
        }
    }
}
