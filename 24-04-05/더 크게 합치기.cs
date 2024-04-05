using System;

public class Solution
{     //두 개의 정수를 받아서 더 큰 값을 반환하는 함수
    public int solution(int a, int b)
    {         // int -> string -> 더하기 -> int.Parse() -> 비교    

        string str1 = a.ToString();     //첫 번째 정수를 문자열로 변환
        string str2 = b.ToString();     //두 번째 정수를 문자열로 변환

        int sum1 = int.Parse(str1 + str2);      //두 문자열을 이어붙여서 만든 숫자를 정수로 변환
        int sum2 = int.Parse(str2 + str1);

        if (sum1 != sum2)       //두 숫자를 비교하여 더 큰 값을 반환
        {
            return Math.Max(sum1, sum2);
        }
        else
        {
            return sum1;
        }
    }
}
