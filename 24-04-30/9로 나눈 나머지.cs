// 문제 : 9로 나눈 나머지
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-30  14:6:27
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int solution(string number)
    {
        int answer = 0;
​
        for (int i = 0; i < number.Length; i++)

​
        return answer % 9;
        //  return number.Select(s => s - '0').Sum() % 9;
    }
}
