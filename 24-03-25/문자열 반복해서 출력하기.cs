// 문제 : 문자열 반복해서 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-25  22:52:5
using System;
​
public class Example
{
    public static void Main()
    {
        String[] input;
​
        Console.Clear();
        input = Console.ReadLine().Split(' ');
​
        String s1 = input[0];
        int a = Int32.Parse(input[1]);
         
        String result = "";
        for(int i = 0; i<a; i++){
            result += s1;

        Console.WriteLine(result);
​
    }
}
