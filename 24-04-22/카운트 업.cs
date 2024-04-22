// 문제 : 카운트 업
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-22  23:41:45
using System;
 
public class Solution {
    public int[] solution(int start, int end) {
        int[] answer = new int[end-start+1];
        int j=0;
        
        for(int i=start; i<=end; i++){
            answer[j] = i;
            j++;
        }
        return answer;
    }

