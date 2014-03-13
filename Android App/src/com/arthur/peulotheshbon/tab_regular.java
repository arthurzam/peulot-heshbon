package com.arthur.peulotheshbon;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.*;

/**
 * basic class for representing the base activity for tab_normal and tab_regular
 * @author arthur
 */
public class tab_regular extends Activity{
	
	private Button bt_plus;
	private Button bt_minus;
	private Button bt_multi;
	private Button bt_divide;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
        setContentView(R.layout.tab_regular);
        
        bt_plus = (Button)findViewById(R.tabs.regular_bt_plus);
        bt_plus.setText(getResources().getStringArray(R.array.operations)[0]);
        
        bt_minus = (Button)findViewById(R.tabs.regular_bt_minus);
        bt_minus.setText(getResources().getStringArray(R.array.operations)[1]);
        
        bt_multi = (Button)findViewById(R.tabs.regular_bt_multi);
        bt_multi.setText(getResources().getStringArray(R.array.operations)[2]);
        
        bt_divide = (Button)findViewById(R.tabs.regular_bt_divide);
        bt_divide.setText(getResources().getStringArray(R.array.operations)[3]);
	}
	
	public void onClick(View v){
		int clickedId = ((Button)v).getId();
		switch(clickedId){
			case R.tabs.regular_bt_plus:
				Data.test_chosen = 0;
				break;
			case R.tabs.regular_bt_minus:
				Data.test_chosen = 1;
				break;
			case R.tabs.regular_bt_multi:
				Data.test_chosen = 2;
				break;
			case R.tabs.regular_bt_divide:
				Data.test_chosen = 3;
				break;
		}
    	startActivity(new Intent(this, RegularTest.class));
	}
}
