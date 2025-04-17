using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        int[] maxvalue = new int[l];
        maxvalue[0]=A[0];
        for (int i=1; i<l; i++)
        {
            int prevvalue = maxvalue[i-1];
            for (int j=2; j<=6; j++)
            {
                if (i-j>=0)
                {
                    prevvalue = Math.Max(prevvalue,maxvalue[i-j]);
                }
            }
            maxvalue[i]=A[i]+prevvalue;
        }
        return maxvalue[l-1];
    }
}