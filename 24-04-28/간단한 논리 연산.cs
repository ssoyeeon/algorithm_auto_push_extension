// 문제 : 간단한 논리 연산
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-28  16:37:14
using System;
​
public class Solution
{
    public bool solution(bool x1, bool x2, bool x3, bool x4)
    {
        bool answer = true;
​
        bool x = x1 || x2;
        bool y = x3 || x4;
​
        answer = x && y;
​
        return answer;
    }

