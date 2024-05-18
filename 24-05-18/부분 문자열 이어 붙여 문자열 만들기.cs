// 문제 : 부분 문자열 이어 붙여 문자열 만들기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-05-18  15:47:42
using System;
​
public class Solution {
    public string solution(string[] my_strings, int[,] parts) {
        string answer = "";
​
            for (int i = 0; i < parts.GetLength(0); i++)
            {
                int s = parts[i, 0];
                int e = parts[i, 1];
​
                answer += my_strings[i].Substring(s, e - s + 1);
            }
​
            return answer;
    }
}
