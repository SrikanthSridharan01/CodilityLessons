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
        int maxdiff =0;
        int diff =0;
        for (int i=0; i<l-1; i++)
        {
            for (int j=i+1; j<l; j++)
            {
                if (A[i]<A[j]){
                    diff = A[j]-A[i];
                }
                if (diff> maxdiff){
                    maxdiff = diff;
                }
            }
        }
        return maxdiff;
    }
}