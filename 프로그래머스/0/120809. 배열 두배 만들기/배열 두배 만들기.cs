using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        return numbers.Select(x=>x*2).ToArray();
    }
}