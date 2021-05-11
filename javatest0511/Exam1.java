package javatest0511;

import java.util.Random;

//기본알고리즘7번째 문제 
public class Exam1 {
	public static void main(String[] args) {
		// 조건1
		int[] arr = new int[10];
		// 조건2
		Random r = new Random();
		// 조건3
		for (int i = 0; i < arr.length; i++) {
			arr[i] = r.nextInt(50) + 1;
		}
//		checkOddEven(arr);

		String strArr[] = getOddEven(arr);
		for(int i=0; i<strArr.length; i++) {
			System.out.println(arr[i] + ":" + strArr[i]);
		}
	}
	
//----------------메소드 ----------------------------------------//
	public static void checkOddEven(int[] arr) {
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] % 2 == 0) {
				System.out.println("짝수");
			} 
			else {
				System.out.println("홀수");
			}
		}
	}
	
	public static String[] getOddEven(int[] arr) {
		String[] strArr = new String[10];
		for (int i = 0; i < arr.length; i++) {
			if (arr[i] % 2 == 0) {
				strArr[i] = "짝수";
			} 
			else {
				strArr[i] = "홀수";
			}
		}
		return strArr;
	}
	
	
}