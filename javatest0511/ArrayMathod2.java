package javatest0511;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.FileReader;
import java.io.IOException;
import java.util.Random;
import java.util.Scanner;

public class ArrayMathod2 {
	public static final int MENU_FILE_WITE = 1; // 상수변수는 대문자로 관례 .final>> 상수변수 한번선언하면 고정됨
	public static final int MENU_FILE_READ = 2;
	public static final int MENU_FILE_EXIT = 3;

	// 메인 시작-----------------------------------------------------------
	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		Random r = new Random();
		
		while (true) {
			menuMenu(s);
			System.out.println("메뉴선택: ");
			int menu = s.nextInt();
			// 메소드 호출
			writemenu(menu,r);
			readMenu(menu);
			exitMenu(menu, s);
		}
	}
	// 메인끝------------------------------------------------

	// 메소드 선언------------------------------------------
	public static void menuMenu(Scanner s) {
		System.out.println("--------------------------");
		System.out.println("파일 제어 프로그램 v1.5");
		System.out.println("--------------------------");
		System.out.println("1. 이름 생성하여 파일에 저장");
		System.out.println("2.파일에서 이름 읽어오기");
		System.out.println("3.종료");
		System.out.println("--------------------------");
		
	}
	public static void writemenu(int menu,Random r) {
		String firstName[] = { "김", "이", "박", "최", "장" };
		String midName[] = { "바", "사", "아", "자", "차" };
		String lastName[] = { "가", "나", "다", "라", "마" };
		String fullName[] = new String[50];
		switch (menu) {
		case MENU_FILE_WITE:
			try {
				FileOutputStream output = new FileOutputStream("testjava.txt");
				for (int i = 0; i < 50; i++) {
					fullName[i] = firstName[r.nextInt(5)] + midName[r.nextInt(5)] + lastName[r.nextInt(5)];
					System.out.println("번호:" + (i + 1) + " " + fullName[i]);
					fullName[i] += "\n";
					output.write(fullName[i].getBytes());
				}
				output.close();
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
			break;
		}
	}

	public static void readMenu(int menu) {
		switch (menu) {
		case MENU_FILE_READ:
			try {
				BufferedReader br = new BufferedReader(new FileReader("testjava.txt"));
				while (true) {
					String line = br.readLine();
					if (line == null) {
						break;
					}
					System.out.println(line);
				}
				br.close();
			} catch (FileNotFoundException e) {
				e.printStackTrace();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

	public static void exitMenu(int menu, Scanner s) {
		switch (menu) {
		case MENU_FILE_EXIT:
			System.out.println("프로그램 종료");
			s.close();
			System.exit(0);
		}
	}

}// 클래스
