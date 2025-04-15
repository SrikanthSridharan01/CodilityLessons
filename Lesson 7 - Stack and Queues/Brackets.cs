using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(string S) {
        // Implement your solution here
        Stack<char> openbrace = new Stack<char>();
        if ((S.Length)%2 != 0){
            return 0;
        }
        else{
            foreach (char brace in S)
            {
                if (brace=='{' || brace== '[' || brace== '(')
                {
                    openbrace.Push(brace);
                }
                else
                {
                    if (openbrace.Count == 0){
                        return 0;     
                    }
                    else
                    {
                        char lastopened = openbrace.Pop();
                        if ((brace=='}' && lastopened!='{') ||
                            (brace==']' && lastopened!='[') ||
                            (brace==')' && lastopened!='(')){
                                return 0;
                            }
                    }
                }
            }
        }
        if (openbrace.Count == 0){
            return 1;
        }
        else{
            return 0;
        }
    }
}
