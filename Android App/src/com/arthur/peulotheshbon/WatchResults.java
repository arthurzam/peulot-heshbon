package com.arthur.peulotheshbon;

import java.util.ArrayList;

import com.arthur.peulotheshbon.data.DatabaseHandler;
import com.arthur.peulotheshbon.data.Mark;
import com.arthur.peulotheshbon.data.StringAdapter;

import android.app.Activity;
import android.content.res.Configuration;
import android.os.Bundle;
import android.widget.GridView;

public class WatchResults extends Activity {
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.watch_result);
        
        GridView grid = (GridView)findViewById(R.id.gridView1);
        {
        	ArrayList<String> l = GetStringsForAdapter();
        	String[] array = new String[l.size()];
        	l.toArray(array);
        	grid.setAdapter(new StringAdapter(this, array));
        }
	}
	
	@Override
	public void onConfigurationChanged(Configuration newConfig) {
	    // Empty, so the activity won't change it's orientation
	}
	
	private ArrayList<String> GetStringsForAdapter(){
		ArrayList<String> list = new ArrayList<String>();
		list.add(getResources().getString(R.string.preference_Name_title));
		list.add(getResources().getString(R.string.date));
		list.add(getResources().getString(R.string.time));
		list.add(getResources().getString(R.string.exam));
		list.add(getResources().getString(R.string.difficulty));
		list.add(getResources().getString(R.string.grade));
		DatabaseHandler db = new DatabaseHandler(this);
		for(Mark m : db.getAllMarks()){
			list.add(m.GetFullName());
			list.add(m.toDateString());
			list.add(m.toTimeString());
			list.add(m.getType());
			list.add(m.getDifficulty());
			list.add(m.getMark() + "");
		}
		db.close();
		return list;
	}
}
