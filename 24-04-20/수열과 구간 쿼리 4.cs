// 문제 : 수열과 구간 쿼리 4
// 결과 :  / 속도: 0 / 메모리 : 0
// 제출시각 : 24-04-20  13:32:28
using System;
​
public class Solution {
    public int[] solution(int[] arr, int[,] queries) {

        for(int i = 0; i < l; i++) { // 각 쿼리에 대해 반복합니다.
            int s = queries[i, 0]; // 쿼리의 시작 인덱스를 가져옵니다.
            int e = queries[i, 1]; // 쿼리의 종료 인덱스를 가져옵니다.
            int k = queries[i, 2]; // 쿼리의 나누는 값(인수)을 가져옵니다.
            for(int j = s; j <= e; j++) { // 시작 인덱스부터 종료 인덱스까지 반복합니다.
                if(j % k == 0) // 현재 인덱스가 나누는 값으로 나누어 떨어지는지 확인합니다.
                    arr[j]++; // 나누어 떨어지면 해당 요소를 1 증가시킵니다.
            }
        }
        return arr; // 변경된 배열을 반환합니다.
    }
}
