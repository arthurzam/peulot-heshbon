package com.arthur.peulotheshbon;

import android.view.View;

public class tab_real extends tab_regular {
	@Override
	public void onClick(View v) {
		Data.tab_chosen = 1;
		super.onClick(v);
	}
}
