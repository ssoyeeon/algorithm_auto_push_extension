// 문제 : 문자열 여러 번 뒤집기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-05-06  18:39:54
using System;
​
public class Solution
{
    public string solution(string my_string, int[,] queries)
    {
        char[] answer = my_string.ToCharArray();
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int startIdx = queries[i, 0];
            int endIdx = queries[i, 1] - queries[i, 0] + 1;
​
            Array.Reverse(answer, startIdx, endIdx);
        }
        return new string(answer);
    }

