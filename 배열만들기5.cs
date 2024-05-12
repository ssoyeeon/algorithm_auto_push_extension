using System;
using System.Collections.Generic;
public class Solution
{
    public int[] solution(string[] intStrs, int k, int s, int l)
    {
        List<int> answer = new List<int>();
        for (int i = 0; i < intStrs.Length; i++)
        {
            int target = Convert.ToInt32(intStrs[i].Substring(s, l));

            if (k < target)
                answer.Add(target);
        }

        return answer.ToArray();
    }
}

