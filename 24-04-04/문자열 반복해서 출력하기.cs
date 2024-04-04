// 문제 : 문자열 반복해서 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-04  11:7:22
using System;
​
public class Example
{
    public static void Main()
    {
        String[] input;
​
        Console.Clear();
        input = Console.ReadLine().Split(' ');      //Split 괄호 '' 안을 기준으로 자름
​
        String result = "";     //result 결과값
        
        for(int i = 0 ; i < Int32.Parse(input[1]); i++)     // int i = 0 i가 input[1]보다 작을때, i를 계속 더함
        {   
            result += input[0];     //input[0]을 결과값에 넣음
        }

    }
}
