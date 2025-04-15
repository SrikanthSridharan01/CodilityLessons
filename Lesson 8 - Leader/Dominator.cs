using System;
using System.Linq;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        for (int i =0; i<l; i++)
        {
            int count = A.Count(x => x==A[i]);
            if (count > l/2.0)
            {
                return i;
            }
        }
        return -1;
    }
}
