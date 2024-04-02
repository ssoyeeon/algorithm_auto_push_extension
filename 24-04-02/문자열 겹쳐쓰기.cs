// 문제 : 문자열 겹쳐쓰기
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-02  9:59:10
using System;
​
public class Solution {
    //주어진 문자열에서 일부를 덮어쓰는 함수
    public string solution(string my_string, string overwrite_string, int s) {
        string myStr = my_string.Substring(0, s);       //시작 위치 s 이전의 부분 문자열을 추출하여 myStr에 저장
        string overStr = my_string.Substring(s + overwrite_string.Length);      //시작 위치 s 이후 덮어쓰기 문자열 이후의 부분 문자열을 추출하여 overStr에 저장
        
        string answer = myStr+overwrite_string+overStr;     //덮어쓰기 작업을 수행한 결과 문자열을 생성
        Console.WriteLine(answer);
        return answer;      // 결과 문자열 반환 

}
