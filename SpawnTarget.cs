using System;

public class Solution
{
    public string solution(string my_string, int[] index_list)
    {
        string answer = "";                             //���ڿ��� ����°� 

        for (int i = 0; i < index_list.Length; i++)     //i�� �ε��� �뵵
            answer += my_string[index_list[i]];     //answer ���� ���� ����

        return answer;
    }
}
