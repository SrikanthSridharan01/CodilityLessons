using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        Array.Sort(A);
        int l = A.Length;
        for (int i=0; i<l-2; i++)
        {
            if (A[i]+A[i+1]>A[i+2])
            {
                return 1;
            }
        }
        return 0;
    }
}
