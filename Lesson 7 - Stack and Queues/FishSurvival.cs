using System;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // Implement your solution here
        int alivefish =0;
        Stack<int> goingdown = new Stack<int>();
        int l = A.Length;
        for (int i=0; i<l; i++){
            // Add Fish going downstream in to the stack
            if (B[i]==1){
                goingdown.Push(A[i]);
            }
            else{
                while (goingdown.Count>0){
                    if(A[i]>goingdown.Peek()){
                        goingdown.Pop();
                    }
                    else{
                        break;
                    }
                }
                if (goingdown.Count == 0){
                    alivefish++;
                }
            }
        }
        return goingdown.Count+alivefish;
    }
}
