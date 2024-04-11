using System;

public class Solution
{
    // 주어진 등차수열의 합을 계산하는 함수
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;

        // 등차수열에 포함되는 각 항에 대해 반복
        for (int i = 0; i < included.Length; i++)
        {
            // included 배열의 값이 true이면 해당 항을 등차수열의 합에 포함
            if (included[i])
                answer += (a + (d * i)); // 등차수열의 i번째 항을 계산하여 합에 추가
        }
        return answer; // 등차수열의 합 반환
    }
}

