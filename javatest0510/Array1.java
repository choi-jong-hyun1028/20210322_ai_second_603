package javatest0510;

import java.util.Iterator;

public class Array1 {

	public static void main(String[] args) {

		int[] arr = new int[100];
		for (int i = 0; i < 100; i++) {
			arr[i] = i + 1;
			if (arr[i] % 5 == 0) {
				System.out.println(arr[i]); // 디버깅 코드
			}
			if (i == 89) {
				break;
			}
		}

		int arr2[][] = { { 1, 2 }, { 2, 4, 6 }, { 3, 6 }, { 4, 8, 10, 12 }, { 10 } };
		for (int i = 0; i < arr2.length; i++) {
			for (int j = 0; j < arr2[i].length; j++) {
				System.out.print(arr2[i][j] + "\t");
			}
			System.out.println();
		}
		//6번문제
		int arrGuga[][]= new int[9][8];
		for (int i=1; i<=9; i++) {
			for(int j=2; j<=9; j++) {
				arrGuga[i-1][j-2] = j*i;
				System.out.printf("%d x %d= %d\t", j,i,arrGuga[i-1][j-2]);
			}
			System.out.println();
		}
	}

}
