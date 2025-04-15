using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int countCars = 0;
        int eastCars = 0;
        foreach (int car in A)
        {
            if (car == 0)
            {
                eastCars++;
            }
            else
            {
                countCars = countCars+eastCars;
                if (countCars > 1000000000)
                {
                    return -1;
                }
            }
        }
        return countCars;
    }
}