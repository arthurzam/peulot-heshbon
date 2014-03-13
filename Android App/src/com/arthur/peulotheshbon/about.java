package com.arthur.peulotheshbon;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;

public class about extends Activity {
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.about);
	}
	
	public void onClick(View v) {
		finish();
	}
}
