using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // Implement your solution here
        int[] count = new int[N];
        for (int i =0; i<A.Length; i++)
        {
            if (A[i]<=N)
            {
                int M = A[i];
                count[M-1]++;
            }
            else if (A[i]>N)
            {
                int max = count.Max();
                for (int j=0; j<N; j++)
                {
                    count[j]=max;
                }
            }
        }
        return count;
    }
}
