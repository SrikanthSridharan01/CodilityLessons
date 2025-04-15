using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        // Implement your solution here
        int divisiblebyb = B/K;
        int divisiblebya = (A-1)/K;
        if (A == 0)
        {
            divisiblebyb++;
        }
        int count = divisiblebyb - divisiblebya;
        return count;
    }
}