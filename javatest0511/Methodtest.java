package javatest0511;

public class Methodtest {

	public static void main(String[] args) {
		// void 존재하면 실행후 종료 2,4형태가 가장많이 쓰임 #method 모든언어 공통 **중요하다**
		// 1. void mthod1() :매개변수 X
		// 2. void mthod2(매개변수........):매개변수 O

		// 타입이 존재하면 반드시 return 필요
		// 3. 타입 method3() : 타입과 일치하는 return 값이 필여
		// 4. 타입 method4() : return 필요, 매개변수 O
		// 5.재귀함수

		// 메소드 호출(사용) 모든 언어 공통
		method1();
		showName();
		showAge();
	}

	// 메소드의 정의 (메인밖에 위치해야한다.)
	public static void method1() {
		for (int i = 0; i < 5; i++)
			System.out.println("method1() 호출");
		showName("최종현", 20);
	}



	public static void showName() {
		String name = "홍길동";
		System.out.println(name);
	}

	public static void showAge() {
		System.out.println("100");
	}
	
	
	//오버로딩(중복 정의)
	//조건1:매개변수 타입이 달라야함
	//조건2:매개변수 개수가 갈라야함
	public static void showName(String name) {
		System.out.println(name);
	}
	
	public static void showName(String name, int age) {
		System.out.println("이름:" + name + "나이:" + age);
	}
	
	
	public static void showName(int age) {
		System.out.println("이름:전우치");
	}
	
}	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	