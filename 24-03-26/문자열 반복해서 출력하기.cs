// 문제 : 문자열 반복해서 출력하기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-03-26  16:34:21
using System;
​
public class Example
{
    public static void Main()
    {
        String[] input;
​
        Console.Clear();  //초기화
        input = Console.ReadLine().Split(' ');  //문자열을 배열해서 넣어줌 현재는 스페이스 기준
​
        //String s1 = input[0];  //s1에 스트링 들어감
        //int a = Int32.Parse(input[1]); //a에 input1이 들어감 5
         
        String result = "";  //문자열 초기화 ""
        //for(int i = 0; i < a; i++){  // i = 0부터 a이전까지 문자열을 계속 더하기
            //result = string
            //result = stringstring
        //    result += s1;
        //}
        
        
        for(int i = 0 ; i < Int32.Parse(input[1]); i++ )
        {
            result += input[0];
        }
        
        Console.WriteLine(result);
​
    }
}
