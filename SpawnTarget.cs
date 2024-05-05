using System;

public class Solution
{
    public string solution(string my_string, int[] index_list)
    {
        string answer = "";                             //문자열로 만드는거 

        for (int i = 0; i < index_list.Length; i++)     //i는 인덱스 용도
            answer += my_string[index_list[i]];     //answer 변수 값에 더해

        return answer;
    }
}
