package com.cjh.carcenterApp.Controller;

import java.util.ArrayList;

import com.cjh.carcenterApp.model.Car;
import com.cjh.carcenterApp.model.CarModify;
import com.cjh.carcenterApp.model.Customer;
import com.cjh.carcenterApp.util.Admin;
import com.cjh.carcenterApp.util.CommUtil;
import com.cjh.carcenterApp.util.RandDate;
import com.cjh.carcenterApp.view.Menu;

public class CarController {
	// DB역활 제네릭class+컬렉션
	ArrayList<Customer> custList = new ArrayList<Customer>();
	ArrayList<CarModify> modiList = new ArrayList<CarModify>();

	// 자동생성
	public void addRandCustData(Customer cust) {
		custList.add(cust);
	}

	// 오버로딩 싱글톤
	public void addRandCustData(int size, RandDate rand) {
		for (int i = 0; i < size; i++) {
			custList.add(new Customer(rand.getName(), rand.getTel(), rand.getmCard(), rand.getbirthday(),
					rand.getemail(), new Car(rand.getModel(), rand.getYear()),
					new CarModify(rand.getcause(), rand.getdateIn(), rand.getdateOut(), rand.getprice(), rand.getIsFix())));
		}

	}

	// 수동생성
	public void addCustData(Customer cust) {
		custList.add(cust);
	}

// Array 리스트 출력 ,고객정보보기 메소드
	public void viewCustData() {
		for (int i = 0; i < custList.size(); i++) {
			System.out.println(custList.get(i).toString());
		}
	}
//일일매출합계 메소드
	public String daysales() {
		int sum = 0;
		for (int i = 0; i < custList.size(); i++) {
			sum += custList.get(i).getCarModify().getPrice();
//			System.out.print(custList.get(i).getCarModify().getPrice());
		}
		return CommUtil.getKorMoney(sum);
	}

	public void doAddWork(Menu m, RandDate rand) {
		while (true) {
			int menu = m.subMenu();
			if (menu == Menu.SUB_MENU_RAN) {
				addRandCustData(m.countdata(), rand);
			} else if (menu == Menu.SUB_MENU_INPUT) {
				addCustData(m.addManualMenu());
			} else if (menu == Menu.SUB_MENU_EXIT) {
				break;
			}

		}
	}

	public void doAdminLogin(Menu m) {
		while (true) {
			String info[] = m.managerLogin();
			if (info[0].equals(Admin.ADMIN_ID) == false) {
				System.out.println("잘못된 ID 입니다.");
				continue;
			} else if (info[1].equals(Admin.ADMIN_PW) == false) {
				System.out.println("잘못된 비번");
				continue;
			} else
				break;
		}
		System.out.println("로그인 성공");
		for (;;) {
			int menu = m.adminMenu() ;
			if (menu == Admin.ADMIN_DAY) {
				System.out.println(daysales());
			} else if (menu == Admin.ADMIN_CAR_FIX) {

			} else if (menu == 3)
				break;
		}
	}

	public void showFixList() {
		//이름 ,연락처,차종,수리완료 여부,수리비
		
	}

}
