using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int X, int Y, int D) {
        // Implement your solution here
        int crossingDistance = Y-X;
        int jump = 0;
        if (crossingDistance != 0)
        {
            if (crossingDistance%D == 0)
            {
                jump = crossingDistance/D;
            }
            else
            {
                jump = (crossingDistance/D)+1;
            }           
        }
        return jump;
    }
}
