package com.arthur.peulotheshbon;

import java.util.Random;

import com.arthur.peulotheshbon.data.*;

import android.app.*;
import android.content.DialogInterface;
import android.os.Bundle;
import android.view.View;
import android.widget.*;

public class RegularTest extends Activity {
	private Targil targil;
	private int mark;
	private Random r = new Random();
	
	private TextView lb_title;
	private TextView lb_targil;
	private EditText tb_result;
	private ProgressBar prograssBar;
	
	@Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
        this.targil = new Targil(Data.test_chosen, Data.tab_chosen == 0);
        targil.RandomTheTargil(r);
        
        setContentView(R.layout.regular_test);

        lb_title = (TextView)findViewById(R.ReguTest.lb_title);
        lb_title.setTextSize(lb_title.getTextSize() + 5);
        lb_title.setText(GetTitle());
        lb_targil = (TextView)findViewById(R.ReguTest.lb_targil);
        lb_targil.setText(targil.toString());
        
        tb_result = (EditText)findViewById(R.ReguTest.tb_answer);
        prograssBar = (ProgressBar)findViewById(R.ReguTest.progressBar);
	}

	private String GetTitle(){
		String type = getResources().getStringArray(R.array.QueTypes)[Data.tab_chosen];
		String test = getResources().getStringArray(R.array.operations)[Data.test_chosen];
		return type + " - " + test;
	}
	
	public void onClick(View v) {
		if(prograssBar.getProgress() + 10 != 100){
			try{
				if(tb_result.getText().length() > 0)
					if(targil.GetRightAnswer() == Integer.parseInt(tb_result.getText().toString()))
						mark += 10;
			}
			catch(NumberFormatException ex) { }
			finally{
				targil.RandomTheTargil(r);
				lb_targil.setText(targil.toString());
				tb_result.setText("");
				prograssBar.setProgress(prograssBar.getProgress() + 10);
			}
		}
		else{
			prograssBar.setProgress(100);
			if(Data.SaveMarks){
				DatabaseHandler db = new DatabaseHandler(this);
				db.addGrade(new Mark(GetTitle(), mark));
				db.close();
			}
			AlertDialog dialog = new AlertDialog.Builder(this).create();  
			dialog.setCancelable(false);
			dialog.setTitle("");
			dialog.setMessage(getResources().getString(R.string.mark_result) + "\n" + mark);  
			dialog.setButton(getResources().getString(R.string.ok), new DialogInterface.OnClickListener() {  
			    @Override  
			    public void onClick(DialogInterface dialog, int which) {  
			    	finish();                      
			    }  
			});  
			dialog.show();
		}
	}

}
