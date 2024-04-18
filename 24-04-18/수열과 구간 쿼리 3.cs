// 문제 : 수열과 구간 쿼리 3
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-18  20:9:14
using System;
​
public class Solution
{
    public int[] solution(int[] arr, int[,] queries)
    {
        int[] answer = arr;
​
        for (int i = 0; i < queries.GetLength(0); i++)
        {
            int f = queries[i, 0];
            int s = queries[i, 1];
​
            int temp = answer[f];
            answer[f] = answer[s];
            answer[s] = temp;
​
        }
        return answer;
    }

