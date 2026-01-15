using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        
        Array.Sort(numbers);
        
        int n=numbers.Length;
        
        return numbers[n-1]*numbers[n-2];
    }
}