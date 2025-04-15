	using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int len = A.Length;
        int sum = ((len+1)*(len+2))/2; // Math Formula for the sum of first N+1 numbers - (N+1)*(N+2)/2
        int arraysum = A.Sum();
        int missinginteger = sum-arraysum;
        return missinginteger;
    }
}
