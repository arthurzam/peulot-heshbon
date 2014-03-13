package com.arthur.peulotheshbon;

import android.view.View;

public class tab_normal extends tab_regular {
	@Override
	public void onClick(View v) {
		Data.tab_chosen = 0;
		super.onClick(v);
	}
}
