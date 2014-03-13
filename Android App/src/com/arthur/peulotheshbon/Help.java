package com.arthur.peulotheshbon;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;

public class Help extends Activity {
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.help);
	}
	
	public void OnClick(View v) {
		finish();
	}
}
