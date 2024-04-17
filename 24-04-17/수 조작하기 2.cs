// 문제 : 수 조작하기 2
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-17  9:18:56
using System;
​
public class Solution
{
    public string solution(int[] numLog)
    {
        string answer = "";
        for (int i = 0; i < numLog.Length - 1; i++)
        {
            int diff = numLog[i + 1] - numLog[i];
​
            switch (diff)
            {
                case 1:
                    answer += "w";
                    break;
                case -1:
                    answer += "s";
                    break;
                case 10:
                    answer += "d";
                    break;
                case -10:
                    answer += "a";
                    break;
            }
        }
        return answer;
    }

