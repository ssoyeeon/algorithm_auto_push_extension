// 문제 : 홀짝 구분하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-01  14:36:35
using System;
​
public class Example
{
    public static void Main()
    {
        String[] s;
​
        Console.Clear();
        s = Console.ReadLine().Split(' ');
​
        int a = Int32.Parse(s[0]);      // 문자열 배열의 첫 번째 요소를 정수로 변환
        if (a % 2 == 0)
            Console.WriteLine($"{a} is even", a);       // 변수 a가 짝수인지 여부

            Console.WriteLine($"{a} is odd", a);        // 변수 a가 홀수인 경우
    }  
}
