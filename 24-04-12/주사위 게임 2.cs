using System;

public class Solution
{
    // 세 개의 정수에 대한 연산을 수행하는 함수
    public int solution(int a, int b, int c)
    {
        int answer = 0;

        // 세 정수가 모두 같은 경우
        if (a == b && a == c)
            answer = (a + b + c) * (a * a + b * b + c * c) * ((int)Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3));
        // 두 정수가 같은 경우
        else if (a == b || b == c || a == c)
            answer = (a + b + c) * (a * a + b * b + c * c);
        // 모든 정수가 다른 경우
        else
            answer = a + b + c;

        return answer; // 연산 결과 반환
    }
}

