using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int[] A) {
        // Implement your solution here
        bool[] leaffall = new bool[X+1];
        int count = 0;
        int i = 0;
        for (i=0; i<A.Length; i++)
        {
            if(A[i]<=X && (!leaffall[A[i]]))
            {
                leaffall[A[i]] = true;
                count++;
            }
            if (count == X)
            {
                return i;
            }
        }
        return -1;
    }
}
