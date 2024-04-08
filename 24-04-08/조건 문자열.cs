using System;

public class Solution
{
    // 부등호(inequality)와 동등기호(equal sign)에 따라 두 정수 n과 m을 비교하여 결과를 반환하는 함수
    public int solution(string ineq, string eq, int n, int m)
    {
        int result = 0;

        // 주어진 부등호에 따라 처리
        if (ineq.Equals(">"))
        {
            // 부등호가 '>'이고 동등기호가 '='일 때
            if (eq.Equals("="))
            {
                result = n >= m ? 1 : 0;    // n이 m보다 크거나 같으면 1, 아니면 0
            }
            else
            {         // 부등호가 '>'이고 동등기호가 '='가 아닐 때
                result = n > m ? 1 : 0;         // n이 m보다 크면 1, 아니면 0
            }
        }
        else if (ineq.Equals("<"))
        {
            // 부등호가 '<'이고 동등기호가 '='일 때
            if (eq.Equals("="))
            {
                result = n <= m ? 1 : 0;        // n이 m보다 작거나 같으면 1, 아니면 0
            }
            else
            {         // 부등호가 '<'이고 동등기호가 '='가 아닐 때
                result = n < m ? 1 : 0;         // n이 m보다 작으면 1, 아니면 0
            }
        }

        return result;      // 결과 반환
    }
}
