using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // Implement your solution here
        int minperimeter = int.MaxValue;
        for (int i=1; i*i<=N; i++)
        {
            if(N%i==0)
            {
                int len = i;
                int width = N/i;
                int perimeter = 2*(len+width);
                if (perimeter<minperimeter)
                {
                    minperimeter=perimeter;
                }
            }
        }
        return minperimeter;
    }
}
