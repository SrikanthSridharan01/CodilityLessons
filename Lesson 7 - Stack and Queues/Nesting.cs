using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // Implement your solution here
        if (S.Length%2!=0)
        {
            return 0;
        }
        else
        {
            Stack<char> openbrackets = new Stack<char>();
            foreach (char brackets in S)
            {
                if (brackets=='(')
                {
                    openbrackets.Push(brackets);
                }
                else
                {
                    if (openbrackets.Count == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        openbrackets.Pop();
                    }
                }
            }
            if (openbrackets.Count == 0)
            {
                return 1;
            }    
            else{
                return 0;
            }            
        }
    }
}
