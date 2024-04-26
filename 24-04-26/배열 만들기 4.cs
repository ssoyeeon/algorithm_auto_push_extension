// 문제 : 배열 만들기 4
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-26  23:31:52
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[] solution(int[] arr)
    {
        List<int> stk = new List<int>();
        int i = 0;
​
        int cnt = 0;
        int lstCnt = 0;
        while (i < arr.Length)
        {
            cnt = stk.Count();
            lstCnt = cnt - 1;
            if (cnt == 0)
            {
                stk.Add(arr[i]);
                i++;
            }
            else if (cnt > 0 && stk[cnt - 1] < arr[i])
            {
                stk.Add(arr[i]);
                i++;
            }
            else if (cnt > 0 && stk[cnt - 1] >= arr[i])
            {
                stk.RemoveAt(lstCnt);
            }
        }
        return stk.ToArray();
    }

