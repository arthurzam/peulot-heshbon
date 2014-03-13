package com.arthur.peulotheshbon;

import android.os.Bundle;
import android.app.TabActivity;
import android.content.Intent;
import android.content.res.Resources;
import android.view.Menu;
import android.view.MenuItem;
import android.widget.*;
import android.widget.TabHost.TabSpec;

public class MainActivity extends TabActivity {
	public static Resources resources;
	
    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        
        setContentView(R.layout.activity_main);
        settingsActivity.loadPreferences(this);
        
        resources = getResources();
        {
        	TabHost tabHost = getTabHost();
        	
        	// Tab for Results
        	TabSpec resultsspec = tabHost.newTabSpec(getResources().getString(R.string.tab_results));
        	// setting Title for the Tab
        	resultsspec.setIndicator(getResources().getString(R.string.tab_results));
        	Intent resultsIntent = new Intent(this, tab_result.class);
        	resultsspec.setContent(resultsIntent);
        	
        	// Tab for Normal
        	TabSpec normalsspec = tabHost.newTabSpec(getResources().getStringArray(R.array.QueTypes)[0]);
        	// setting Title for the Tab
        	normalsspec.setIndicator(getResources().getStringArray(R.array.QueTypes)[0]);
        	normalsspec.setContent(new Intent(this,tab_normal.class));
        	
        	// Tab for Real
        	TabSpec realsspec = tabHost.newTabSpec(getResources().getStringArray(R.array.QueTypes)[1]);
        	// setting Title for the Tab
        	realsspec.setIndicator(getResources().getStringArray(R.array.QueTypes)[1]);
        	realsspec.setContent(new Intent(this,tab_real.class));
        	
        	// Adding all TabSpec to TabHost
        	tabHost.addTab(resultsspec);
        	tabHost.addTab(normalsspec);
        	tabHost.addTab(realsspec);
        
        	tabHost.getChildAt(0).setVisibility(0);
        	
        }
    }
    
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.activity_main, menu);
        return true;
    }
    
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
    	Intent start = null;;
        switch (item.getItemId()) {
            case R.menu.settings:
            	start = new Intent(this,settingsActivity.class);
    			break;
            case R.menu.about:
            	start = new Intent(this,about.class);
    			break;
            case R.menu.help:
            	start = new Intent(this,Help.class);
    			break;
            case R.menu.contact:
            	start = new Intent(Intent.ACTION_SEND);
            	start.setType("plain/text");
            	start.putExtra(Intent.EXTRA_EMAIL, new String[]{"arthurzam@gmail.com"});
            	start.putExtra(Intent.EXTRA_SUBJECT, getResources().getString(R.string.email_title));
            	start.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            	break;
        }
        if(start != null)
        	startActivity(start);
        return true;
    }

    @Override
    protected void onDestroy() {
    	super.onDestroy();
    }
    
    /*private boolean CheckRoot(){
    	Process p;  
    	try {  
    	   // Preform su to get root privledges  
    	   p = Runtime.getRuntime().exec("su");   
    	   // Attempt to write a file to a root-only  
    	   java.io.DataOutputStream os = new java.io.DataOutputStream(p.getOutputStream());  
    	   os.writeBytes("echo \"Do I have root?\" >/system/sd/temporary.txt\n");  
    	  
    	   // Close the terminal  
    	   os.writeBytes("exit\n");  
    	   os.flush();  
    	   try {  
    	      p.waitFor();  
    	           if (p.exitValue() != 255) { 
    	              return true;  
    	           }  
    	           else { 
    	        	   return false;  
    	           }  
    	   } catch (InterruptedException e) {  
    		   return false;  
    	   }  
    	} catch (java.io.IOException e) {  
    		return false;  
    	}
    }*/
}
