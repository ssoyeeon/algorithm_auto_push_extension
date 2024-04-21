// 문제 : 배열 만들기 2
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-21  10:59:39
using System;
using System.Collections.Generic;
using System.Linq;
​
public class Solution {
    public int[] solution(int l, int r) {
        int[] answer = new int[] {}; // 결과를 저장할 배열
​
        // 범위 내에서 특정 조건을 만족하는 숫자를 찾아 배열로 반환합니다.
        answer = Enumerable.Range(l, r - l + 1) // 범위 내의 숫자를 생성합니다.
                   .Where(x => x.ToString().All(y=> y == '5' || y == '0')) // 조건을 만족하는 숫자를 필터링합니다.
                   .ToArray(); // 배열로 변환합니다.
​
        if(answer.Length <= 0) // 결과 배열이 비어 있는 경우
            return new int[] {-1}; // -1을 요소로 갖는 배열을 반환합니다.
        return answer; // 결과 배열을 반환합니다.
    }
}

