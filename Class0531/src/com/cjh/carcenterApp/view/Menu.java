package com.cjh.carcenterApp.view;

import java.util.Random;
import java.util.Scanner;

import com.cjh.carcenterApp.model.Car;
import com.cjh.carcenterApp.model.CarModify;
import com.cjh.carcenterApp.model.Customer;

public class Menu {
	//class 변수 final>> 상수
	public static final int MAIN_MENU_ADD = 1;
	public static final int MAIN_MENU_VIEW = 2;
	public static final int MAIN_MENU_ADMIN = 3;
	public static final int MAIN_MENU_EXIT = 4;
	
	public static final int SUB_MENU_RAN = 1;
	public static final int SUB_MENU_INPUT = 2;
	public static final int SUB_MENU_EXIT = 3;
	
	Scanner s = new Scanner(System.in);
	Random r = new Random();
	
	public int mainMenu() {
		System.out.println("---------------------");
		System.out.println("카센터 관리 프로그램 v1.0");
		System.out.println("---------------------");
		System.out.println("1.고객정보등록");
		System.out.println("2.고객정보보기");
		System.out.println("3.관리자 모드");
		System.out.println("4.프로그램 종료");
		System.out.println("---------------------");
		System.out.println("메인메뉴 선택");
		return s.nextInt();
	}
	
	public int subMenu() {
		System.out.println("++++++++++++++++++++");
		System.out.println("++ 고객등록 정보화면 ++");
		System.out.println("++++++++++++++++++++");
		System.out.println("1.자동생성");
		System.out.println("2.수동생성");
		System.out.println("3.메인메뉴 이동");
		return s.nextInt();
	}
	
	public int countdata() {
		System.out.println("몇명의 데이터를 생성하시겠습니까?");
		return s.nextInt();
	}
	
	public Customer addManualMenu() {
		System.out.println("++++++++++++++++++++");
		System.out.println("++ 고객등록 수동입력 ++");
		System.out.println("++++++++++++++++++++");
		
		System.out.print("고객명:"); 
		String name = s.next();
		System.out.print("연락처");
		String tel = s.next();
		System.out.print("멤버쉽 보유(Y:true,N:false):");
		boolean mcard = s.nextBoolean();
		System.out.print("생일:");
		String birthday = s.next();
		System.out.print("이메일:");
		String email = s.next();
		
		
		System.out.print("차량모델:");
		String model = s.next();
		System.out.print("연식:");
		String year = s.next();
		
		
		System.out.print("수리내역:");
		String cause = s.next();
		System.out.print("접수날짜:");
		int dateIn = s.nextInt();
		System.out.print("수리예정날짜:");
		int dateOut = s.nextInt();
		System.out.print("수리비:");
		int price = s.nextInt();
		System.out.print("수리완료(Y:true,N:false):");
		boolean fix = s.nextBoolean();
		
		return new Customer(name, tel, mcard, birthday, email,
				new Car(model, year),
				new CarModify(cause, dateIn, dateOut, price, fix));
	}
	
	public String[] managerLogin() {
		System.out.println("//////////////////");
		System.out.println("// 관리자 모드 접속 //");
		System.out.println("//////////////////");
		
		System.out.print("ID: ");
		String id = s.next();
		System.out.print("PW: ");
		String pw = s.next();
		String[] info = {id,pw};
		return info;
	}
	
	public int adminMenu() {
		System.out.println("//////////////////");
		System.out.println("// 관리자 모드 접속 //");
		System.out.println("//////////////////");
		System.out.println("1.일일매출");
		System.out.println("2.차량수리내역");
		System.out.println("3.메인메뉴 이동");
		return s.nextInt();
	}
	
	
	
	
	
	
	
	
}
