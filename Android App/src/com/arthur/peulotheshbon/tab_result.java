package com.arthur.peulotheshbon;

import com.arthur.peulotheshbon.data.DatabaseHandler;

import android.app.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.os.Environment;
import android.view.View;
import android.widget.*;

public class tab_result extends Activity {
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.tab_results);
        DatabaseHandler db = new DatabaseHandler(this);
        ((TextView)findViewById(R.tabs.results_lb_average)).setText(getResources().getString(R.string.tab_results_lb_average) + " " + db.GetAverageMarks());
        db.close();
        if (!Environment.MEDIA_MOUNTED.equals(Environment.getExternalStorageState())) {
        	((Button)findViewById(R.tabs.results_csv_save)).setEnabled(false);
    	}
    }
    
	@Override
    protected void onResume() {
    	super.onResume();
    	DatabaseHandler db = new DatabaseHandler(this);
        ((TextView)findViewById(R.tabs.results_lb_average)).setText(getResources().getString(R.string.tab_results_lb_average) + " " + db.GetAverageMarks());
        db.close();
    }
	
    public void bt_watch_Click(View v)
    {
    	startActivity(new Intent(this, WatchResults.class));
    }
    
    public void bt_save_csv_Click(View v){
    	DatabaseHandler db = new DatabaseHandler(this);
    	db.ConvertToCsv();
    	db.close();
    }
}
