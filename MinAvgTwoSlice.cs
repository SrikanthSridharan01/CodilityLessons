using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        double minavg = double.MaxValue;
        int Q = A.Length-1;
        int mininteger = 0;
        for (int i=0; i<Q; i++)
        {
            double sum = A[i];
            for (int j=i+1; j<A.Length; j++)
            {
                sum = sum+A[j];
                double avg = sum/(j-i+1);
                if (avg<minavg || (avg == minavg && i<mininteger))
                {
                    minavg = avg;
                    mininteger = i;
                }
            }
        }
    return mininteger;
    }
}
