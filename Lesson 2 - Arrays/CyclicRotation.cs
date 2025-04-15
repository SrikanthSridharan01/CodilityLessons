using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A, int K) {
        // Implement your solution here
        int[] B = new int[A.Length];
        for (int j=1; j<=K; j++)
        {
            for (int i=0; i<(A.Length-1); i++)
            {
                B[i+1]=A[i];
            }
            B[0]=A[A.Length-1];
            Array.Copy(B, A, B.Length);
        }
        return A;
    }
}
