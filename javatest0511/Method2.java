package javatest0511;

import java.util.Scanner;

public class Method2 {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		System.out.print("첫번쨰 항 입력:");
		int num1 = s.nextInt();
		System.out.print("두번쨰 항 입력:");
		int num2 = s.nextInt();
		System.out.print("연산자 입력(+,-,*,/):");
		String op = s.next();
		
		//메소드 불러오기
		calcu(num1, num2, op);
		calcu(100, 20, "+");
	}

	// 간단한 사칙연산 계산기 (메소드 제작)
	public static void calcu(int num1, int num2, String op) {
		// if문
		/*
		 * if(op == "+") { System.out.println(num1+num2); } else if(op == "-") {
		 * System.out.println(num1-num2); } else if(op == "*") {
		 * System.out.println(num1*num2); } else if(op == "/") {
		 * System.out.println(num1/num2); }
		 */

		// switch문
		switch (op) {
		case "+":
			System.out.println(num1 + num2);
			break;
		case "-":
			System.out.println(num1 - num2);
			break;
		case "*":
			System.out.println(num1 * num2);
			break;
		case "/":
			System.out.println(num1 / num2);
			break;
		}
	}

}
