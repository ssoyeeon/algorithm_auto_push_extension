// 문제 : 덧셈식 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-28  15:37:20
using System;
​
public class Example
{

    {
        String[] s;
​
        Console.Clear();
        s = Console.ReadLine().Split(' ');      //공백 지워서 4, 5로 나누기 
​
        int a = Int32.Parse(s[0]);      //0번에 a넣기
        int b = Int32.Parse(s[1]);      //1번에 b넣기
​
        Console.WriteLine("{0} + {1} = {2}", a, b, a + b);      //0에 a 1에 b 2가 a+b
    }
}
