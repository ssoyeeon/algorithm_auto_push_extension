// 문제 : 대소문자 바꿔서 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-26  16:34:6
using System;
​
public class Example
{
    public static void Main()
    {
        String s;
​
        Console.Clear();
        s = Console.ReadLine();
        
        String result = "";
        
        foreach (char c in s)
        {

            {
                result += char.ToUpper(c); // result = result + char.ToUpper(c)
            }
            else if (char.IsUpper(c))
            {
                result += char.ToLower(c);
            }
        }
        
        Console.WriteLine(result);
​
    }
}
