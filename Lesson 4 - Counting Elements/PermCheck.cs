using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) 
    {
        // Implement your solution here
        int len = A.Length;
        foreach (int num in A)
        {
            if (num>len) // for a permuation from 1 to N, the numbers cannot be greater than N (N is the length of the array)
            {
                return 0;
            }
        }
        return 1;
    }
}
