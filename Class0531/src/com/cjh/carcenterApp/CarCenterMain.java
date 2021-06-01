package com.cjh.carcenterApp;

import java.text.DecimalFormat;
import java.util.Iterator;

import com.cjh.carcenterApp.Controller.CarController;
import com.cjh.carcenterApp.model.Car;
import com.cjh.carcenterApp.model.CarModify;
import com.cjh.carcenterApp.model.Customer;
import com.cjh.carcenterApp.util.Admin;
import com.cjh.carcenterApp.util.RandDate;
import com.cjh.carcenterApp.view.Menu;

public class CarCenterMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Menu m = new Menu();
		RandDate rand = new RandDate();
		CarController con = new CarController();

		while (true) {
			switch (m.mainMenu()) {
			case Menu.MAIN_MENU_ADD:
//				while (true) {
//					int menu = m.subMenu();
//					if (menu == Menu.SUB_MENU_RAN) {
//						con.addRandCustData(m.countdata(),rand);
//					} 
//					else if (menu == Menu.SUB_MENU_INPUT) {
//						con.addCustData(m.addManualMenu());
//					} 
//					else if (menu == Menu.SUB_MENU_EXIT) {
//						break;
//					}
//
//				}
				con.doAddWork(m, rand);
				break;
				
			case Menu.MAIN_MENU_VIEW:
				con.viewCustData();
				break;

			case Menu.MAIN_MENU_ADMIN:
//				while (true) {
//					String info[] = m.managerLogin();
//					if (info[0].equals(Admin.ADMIN_ID)==false) {
//						System.out.println("잘못된 ID 입니다.");
//						continue;
//					}
//					else if (info[1].equals(Admin.ADMIN_PW)==false) {
//						System.out.println("잘못된 비번");
//						continue;
//					}
//					else break;
//				}
//				System.out.println("로그인 성공");
				
				//for무한루프
//				for(;;) {
//					int menu = m.adminMenu();
//					if (menu ==Admin.ADMIN_DAY) {
//						
//					}
//					else if (menu == Admin.ADMIN_CAR_FIX) {
//						
//					}
//					else if (menu ==3)break;
//				}
				con.doAdminLogin(m);
//				con.doAdminWork(m);
				break;

			case Menu.MAIN_MENU_EXIT:
				System.out.println("프로그램 종료");
				System.exit(0);
			}

		}
	}

}
