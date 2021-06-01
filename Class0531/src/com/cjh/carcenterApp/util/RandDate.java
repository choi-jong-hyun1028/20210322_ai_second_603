package com.cjh.carcenterApp.util;

import java.util.Random;

public class RandDate {

	String name[] = { "홍길동", "김길동", "박길동", "이길동", "최길동" };
	String tel[] = { "010-1234-5678", "010-1234-5678", "010-1234-5678", "010-1234-5678", "010-1234-5678", };
	boolean mCard[] = { true, false };
	String birthday[] = { "1990년1월20일", "1990년2월20일", "1990년3월20일", "1990년4월20일", "1990년5월20일" };
	String email[] = { "hong1@gmail.com", "hong1@gmail.com", "hong1@gmail.com", "hong1@gmail.com", "hong1@gmail.com" };
	String model[] = { "SM6", "SM3", "SM5", "SM7", "SM9", };
	String year[] = { "2018", "2014", "2015", "2011", "2000" };
	String cause[] = { "엔진오일교체", "와이퍼교체", "타이어교체", "에어컨가스충전", "에어컨필터교체" };
	int dateIn[] = { 20210520, 20210420, 20210720, 20211220, 20211020 };
	int dateOut[] = { 20210520, 20210420, 20210720, 20211220, 20211020 };
	int price[] = { 20000, 30000, 40000, 50000, 60000 };
	boolean isFix[] = {true,false};

	

	Random r = new Random();

	public String getName() {
		return name[r.nextInt(5)];
	}

	public String getTel() {
		return tel[r.nextInt(5)];
	}

	public boolean getmCard() {
		return mCard[r.nextInt(2)];
	}

	public String getbirthday() {
		return birthday[r.nextInt(5)];
	}

	public String getModel() {
		return model[r.nextInt(5)];
	}

	public String getemail() {
		return email[r.nextInt(5)];
	}

	public String getYear() {
		return year[r.nextInt(5)];
	}

	public String getcause() {
		return cause[r.nextInt(5)];
	}

	public int getdateIn() {
		return dateIn[r.nextInt(5)];
	}

	public int getdateOut() {
		return dateOut[r.nextInt(5)];
	}

	public int getprice() {
		return price[r.nextInt(5)];
	}
	
	public boolean getIsFix() {
		return isFix[r.nextInt(2)];
	}

}
