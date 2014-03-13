package com.arthur.peulotheshbon;

import android.app.Activity;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Spinner;

public class settingsActivity extends Activity {
	
	public static final String PREFS_NAME = "app_settings";
	
	public static final String NAME_KEY = "full_name";
	public static final String DIFFICULTY_KEY = "diff";
	public static final String SAVEMARKS_KEY = "save_mark";
	
	private EditText tb_name;
	private Spinner ddp_difficulty;
	private CheckBox cb_saveName;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.settings);
        
        loadPreferences(this);
        
        tb_name = (EditText)findViewById(R.settings.tb_name);
        tb_name.setText(Data.full_name);
        
        ddp_difficulty = (Spinner)findViewById(R.settings.ddp_difficulty);
        ddp_difficulty.setSelection(Data.chosenDifficulty);
        
        cb_saveName = (CheckBox)findViewById(R.settings.cb_saveMark);
        cb_saveName.setChecked(Data.SaveMarks);
        
	}
	
	@Override
	public void onBackPressed() {
		savePreferentes();
		super.onBackPressed();
	}
	
	@Override
	protected void onResume() {
		loadPreferences(this);
		super.onResume();
	}
	
	public static void loadPreferences(Context context) {
		  SharedPreferences settings = context.getSharedPreferences(PREFS_NAME, Context.MODE_APPEND);
		  
		  Data.chosenDifficulty = settings.getInt(DIFFICULTY_KEY, 0);
		  Data.full_name = settings.getString(NAME_KEY, "");
		  Data.SaveMarks = settings.getBoolean(SAVEMARKS_KEY, true);
	}
	
	private void savePreferentes() {
		  SharedPreferences settings = getSharedPreferences(PREFS_NAME, Context.MODE_APPEND);
		  SharedPreferences.Editor editor = settings.edit();

		  editor.putString(NAME_KEY, tb_name.getText().toString());
		  editor.putInt(DIFFICULTY_KEY, ddp_difficulty.getSelectedItemPosition());
		  editor.putBoolean(SAVEMARKS_KEY, cb_saveName.isChecked());
		  editor.commit();
		  
		  Data.chosenDifficulty = settings.getInt(DIFFICULTY_KEY, 0);
		  Data.full_name = settings.getString(NAME_KEY, "");
		  Data.SaveMarks = cb_saveName.isChecked();
	}
}