// 문제 : 문자열 섞기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-03  9:4:23
using System;
​
public class Solution {

{
        string answer = "";      // 결과 문자열 초기화
        for(int i=0; i<str1.Length; i++)         // 두 문자열의 길이만큼 반복
            answer +=str1[i].ToString()+str2[i].ToString();      // 각 문자열의 해당 위치 문자를 번갈아가며 결과 문자열에 추가
        return answer;
    }
}
