// 문제 : a와 b 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-25  22:58:48
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
        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);
​
       Console.WriteLine("a = {0}", a);

    }
}
