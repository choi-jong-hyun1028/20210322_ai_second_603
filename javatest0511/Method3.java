package javatest0511;

public class Method3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//타입 메소드
		System.out.println("나이:" + getAge(100));
		System.out.println("이름:" + getName("최"));
		
	}
	
	public static int getAge() {
		int age = 500;
		return age;
	}
	
	public static String getName() {
		String name = "홍길동";
		return name;
	}
	
	public static int getAge(int age) {
		return age + 100;
	}
	
	public static String getName(String lastName) {
		return lastName + "길동";
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
}
