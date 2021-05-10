package javatest0510;

import java.util.Scanner;

public class Loop2 { // 클래스이름 첫자는 대문자 관례
	public static final int MENU_FILE_WITE = 1; // 상수변수는 대문자로 관례 .final>> 상수변수 한번선언하면 고정됨
	public static final int MENU_FILE_READ = 2;
	public static final int MENU_FILE_EXIT = 3;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		while (true) {
			System.out.println("--------------------------");
			System.out.println("간단한 파일 관리 프로그램 v1.0");
			System.out.println("--------------------------");
			System.out.println("1. 파일 생성 및 쓰기");
			System.out.println("2.파일 읽기");
			System.out.println("3.종료");
			System.out.println("--------------------------");
			System.out.println("메뉴선택: ");
			int menu = s.nextInt();
			switch (menu) {
			case MENU_FILE_WITE:
				System.out.println("파일 생성 및 쓰기 처리");
				break;
			case MENU_FILE_READ:
				System.out.println("파일 읽기 처리");
				break;
			case MENU_FILE_EXIT:
				System.out.println("프로그램 종료");
				s.close();
				System.exit(0);
				break;
			}

		}
	}
}
