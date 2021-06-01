package com.cjh.carcenterApp.util;

import java.text.DecimalFormat;

public class CommUtil {
	public static String getKorMoney(int money) {
		
		DecimalFormat dc = new DecimalFormat("###,###,###,###");
		return "￦" + dc.format(money)+"원";
	}
}
