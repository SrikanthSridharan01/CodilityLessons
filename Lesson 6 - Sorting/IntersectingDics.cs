using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // Implement your solution here
        int l = A.Length;
        int[] lowerrange = new int[l];
        int[] upperrange = new int[l];
        for (int i=0; i<l; i++)
        {
            lowerrange[i]=i-A[i];
            upperrange[i]=i+A[i];
        }
        Array.Sort(lowerrange);
        Array.Sort(upperrange);
        int intersection =0;
        int j = 0;
        for (int i=0; i<l; i++)
        {
            while (j<l && upperrange[i]>=lowerrange[j])
            {
                j++;
            }
            intersection = intersection+j-i-1;
            if (intersection>10000000)
            {
                return -1;
            }
        }
        return   intersection;     
    }
}
