using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        Array.Sort(A);
        int l = A.Length;
        int product1 = A[l-1]*A[l-2]*A[l-3];
        // if the array has negative number, take the two least negative number & the max positive
        int product2 = A[0]*A[1]*A[l-1];
        int maxproduct = Math.Max(product2, product1);
        return maxproduct;
    }
}
