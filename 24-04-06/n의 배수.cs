using System;

public class Solution
{
    public int solution(int num, int n)
    {       // num을 n으로 나누어 떨어지는지 확인하는 함수
        int answer = 0;
        if (num % n == 0)
        {       // num이 n으로 나누어 떨어지면 answer를 1로 설정
            answer = 1;
        }
        else
        {
            answer = 0;     // 그렇지 않으면 answer를 0으로 설정
        }
        return answer;
    }
}
