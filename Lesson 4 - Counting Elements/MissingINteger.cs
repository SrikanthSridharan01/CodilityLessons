using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) 
    {
        // Implement your solution here
        int smallposint = 1;
        if (A.Any(x => x<0))
        {
            return smallposint;
        }
        else
        {
            // Make the array a clean array by removing all 0 and negative
            var positivearray = A.Where(x => x>0);
            // Remove Duplicates
            var disctinctarray = positivearray.Distinct().ToList();
            //convert to list & sort
            var cleanarray = disctinctarray.ToList().sort();
            cleanarray.Sort();
                foreach (int num in cleanarray)
                {
                    if (num != smallposint)
                    {
                        return smallposint;
                    }
                    smallposint++;
                }
        }
        
        return smallposint; 
    }
}
