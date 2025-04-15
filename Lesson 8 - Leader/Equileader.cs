using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        int dominator = 0;
        int dominatorcount = 0;
        foreach (int num in A)
        {
            int count = A.Count(x => x==num);
            if (count>l/2.0)
            {
               dominator = num;
               dominatorcount = count;
               break;
            }         
        }
        int equileader = 0;
        int currentdominatorcount = 0;
        for (int i =0; i<l; i++)
        {
            if (A[i]==dominator)
            currentdominatorcount++;
            if (currentdominatorcount>(i+1)/2 && (dominatorcount-currentdominatorcount)>(l-i-1)/2)
            {
                equileader++;
            }
        }
    return equileader;
    }
}
