package com.cjh.carcenterApp.model;

import com.cjh.carcenterApp.util.CommUtil;

public class CarModify {
	private String cause; // 고장원인
	private int dateIn; // 접수날짜
	private int dateOut; // 수리완료
	private int price; // 견적
	private boolean isFix;

	public CarModify(String cause, int dateIn, int dateOut, int price) {
		super();
		this.cause = cause;
		this.dateIn = dateIn;
		this.dateOut = dateOut;
		this.price = price;

	}

	public CarModify(String cause, int dateIn, int dateOut, int price, boolean isFix) {
		super();
		this.cause = cause;
		this.dateIn = dateIn;
		this.dateOut = dateOut;
		this.price = price;
		this.isFix = isFix;
	}

	public String getCause() {
		return cause;
	}

	public void setCause(String cause) {
		this.cause = cause;
	}

	public int getDateIn() {
		return dateIn;
	}

	public void setDateIn(int dateIn) {
		this.dateIn = dateIn;
	}

	public int getDateOut() {
		return dateOut;
	}

	public void setDateOut(int dateOut) {
		this.dateOut = dateOut;
	}

	public int getPrice() {
		return price;
	}

	public void setPrice(int price) {
		this.price = price;
	}

	public boolean isFix() {
		return isFix;
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		String str = "수리내역: " + cause + "\n";
		str += "접수날짜: " + dateIn + "\n";
		str += "수리완료날짜: " + dateOut + "\n";
		str += "수리비: " + CommUtil.getKorMoney(price) + "\n";
		return str;
	}
}
