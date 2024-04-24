// 문제 : 콜라츠 수열 만들기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-24  13:20:25
using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int n) {
     List<int> answer = new List<int>();
            answer.Add(n);
            while (n != 1)
            {
                if (n % 2 == 0)
                    n = n / 2;
                else
                    n = 3 * n + 1;
                    answer.Add(n);
            }
            return answer.ToArray() ;
    }

