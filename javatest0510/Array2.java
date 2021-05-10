package javatest0510;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class Array2 {
	public static final int MENU_FILE_WITE = 1; // 상수변수는 대문자로 관례 .final>> 상수변수 한번선언하면 고정됨
	public static final int MENU_FILE_READ = 2;
	public static final int MENU_FILE_EXIT = 3;

	public static void main(String[] args) {
		String firstName[] = { "김", "이", "박", "최", "장" };
		String midName[] = { "바", "사", "아", "자", "차" };
		String lastName[] = { "가", "나", "다", "라", "마" };
		Random r = new Random();
		String fullName[] = new String[50];
		Scanner s = new Scanner(System.in);
		while (true) {
			System.out.println("--------------------------");
			System.out.println("파일 제어 프로그램 v1.5");
			System.out.println("--------------------------");
			System.out.println("1. 이름 생성하여 파일에 저장");
			System.out.println("2.파일에서 이름 읽어오기");
			System.out.println("3.종료");
			System.out.println("--------------------------");
			System.out.println("메뉴선택: ");
			int menu = s.nextInt();
			switch (menu) {
			case MENU_FILE_WITE:
				for (int i = 0; i < 50; i++) {
					fullName[i] = firstName[r.nextInt(5)] + midName[r.nextInt(5)] + lastName[r.nextInt(5)];
					System.out.println("번호:" + (i+1)+ " " +fullName[i]);
					try {
						FileOutputStream output = new FileOutputStream("testjava.txt");
						output.close();
					} catch (FileNotFoundException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					} catch (IOException e) {
						// TODO Auto-generated catch block
						e.printStackTrace();
					}
				}
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
