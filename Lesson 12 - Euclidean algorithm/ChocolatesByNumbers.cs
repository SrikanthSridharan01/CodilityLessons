using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N, int M) {
        // Implement your solution here
        int x =0;
        int count =1;
        while ((x+M)%N!=0)
        {
            count++;
            x=(x+M)%N;
        }
        return count;
    }
}
