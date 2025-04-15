using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution 
{
    public int solution(int[] A) 
    {
        // Implement your solution here
        var distcintarray = A.Distinct();
        var distcintarraylist = distcintarray.ToList();
        int distinctcount = distcintarraylist.Count();
        return distinctcount;
    }
}
