// 문제 : 수열과 구간 쿼리 2
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-19  20:12:39
using System;
​
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {
        int l = queries.GetLength(0);
        int[] answer = new int[l];
        int s = 0;
        int e = 0;
        int k = 0;
​
        for(int i = 0; i<l;i++)
        {
            s = queries[i,0];
            e = queries[i,1];
            k = queries[i,2];
            int temp = -1;
            for(int j = s; j<=e; j++)
            {
                if(arr[j]>k&&temp==-1)
                    temp = arr[j];
                if(arr[j]<=temp&&arr[j]>k)
                    temp = arr[j];           
            }
            answer[i] = temp;
        }
​
        return answer;
    }

