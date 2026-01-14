using System;

public class Solution {
    public int[] solution(int money) {
        int[] answer = new int[] {};
        
        int cups = money/5500;
        int remain = money%5500;
        answer = new int[] {cups, remain};
        
        return answer;
    }
}