// 문제 : 문자열 붙여서 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-29  22:1:21
using System;
​
public class Example
{
    public static void Main()
    {
        String[] input;
​
        Console.Clear();        //초기화
        input = Console.ReadLine().Split(' ');      //' '안에 있는거 지우기
​
        String s1 = input[0];       //s1이 0번
        String s2 = input[1];       //s2가 1번
        String output = s1+s2.Replace(" ","");      //공백을 제거한 s2를 생성하고 s1과 결합하여 output에 저장

        
        Console.WriteLine(output);
    }
}
