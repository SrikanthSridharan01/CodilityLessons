using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int oddNumber = 0;
        for (int i=0; i<A.Length; i++)
        {
            int count = 0;
            for (int j=0; j<A.Length; j++)
            {
                if (A[i]==A[j])
                {
                    count++;
                }
            }
            if (count%2 != 0)
            {
                oddNumber = A[i];
            }
        }
        return oddNumber;
    }
}
