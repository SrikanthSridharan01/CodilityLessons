using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // Implement your solution here
        int count=1;
        for (int i=1; i<=N/2; i++)
        {
            if (N%i == 0)
            {
                count++;
            }
        }
        return count;
    }
}
