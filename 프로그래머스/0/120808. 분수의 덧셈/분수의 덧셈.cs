using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int numer = numer1 * denom2 + numer2 * denom1;
        int denom = denom1 * denom2;
        
        int gcd = GCD(numer, denom);
        
        numer /= gcd;
        denom /= gcd;
        
        return new int[] {numer, denom};
    }
    public int GCD(int a, int b){
        while(b != 0){
            int temp = a%b;
            a = b;
            b = temp;
        }
        return a;
    }
}