using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(string S, int[] P, int[] Q) {
        // Implement your solution here
        int[] minimalfactor = new int[P.Length];
        for (int i =0; i<P.Length; i++)
        {
            string sub = S.Substring(P[i], (Q[i]-P[i]+1));
            if (sub.Contains("A"))
            {
                minimalfactor[i] = 1;
            }
            else if (sub.Contains("C"))
            {
                minimalfactor[i] = 2;
            }
            else if (sub.Contains("G"))
            {
                minimalfactor[i] = 3;
            }
            else 
            {
                minimalfactor[i] = 4;
            }
        }
        return minimalfactor;
    }
}