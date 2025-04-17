using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        int count =0;
        List<int> nondivisors = new List<int>();
        foreach(int num in A)
        {
            count = 0;
            for (int i=0; i<l; i++)
            {     
                       
                    if (num<A[i])
                    {
                        count++;
                    }
                    else{
                        if (num%A[i] != 0)
                        {
                            count++;
                        }
                    }
            }
            nondivisors.Add(count);
        }
        int[] nondivisorarray = nondivisors.ToArray();
        return nondivisorarray;
    }
}