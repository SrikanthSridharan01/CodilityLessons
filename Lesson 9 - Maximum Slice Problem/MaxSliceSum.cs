using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        int maxsum=int.MinValue;
        for (int i=0; i<l; i++)
        {
            int sum =0;
            for (int j=i; j<l; j++)
            {
                sum = sum+A[j];
            if (sum>maxsum){
                maxsum = sum;
                }
            }
        }
        return maxsum;
    }
}
