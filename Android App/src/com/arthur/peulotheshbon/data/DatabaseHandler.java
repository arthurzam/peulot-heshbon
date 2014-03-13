package com.arthur.peulotheshbon.data;

import java.io.FileWriter;
import java.util.ArrayList;
import java.util.List;

import com.arthur.peulotheshbon.MainActivity;
import com.arthur.peulotheshbon.R;

import android.content.ContentValues;
import android.content.Context;
import android.database.*;
import android.database.sqlite.*;
import android.os.Environment;

/**
 * a class for working with the grades database.
 * @author Arthur
 */
public class DatabaseHandler extends SQLiteOpenHelper {
	private static final String DATABASE_NAME = "Grades.db";
	private static final String DATABASE_TABLE = "mainTable";
	private static final int DATABASE_VERSION = 2;
	
	// The index (key) column name for use in where clauses.
	
	public static final String KEY_ID="_id";
	public static final int ID_COLUMN = 0;
	public static final String KEY_NAME="name";
	public static final int NAME_COLUMN = 1;
	public static final String KEY_DATE="date";
	public static final int DATE_COLUMN = 2;
	public static final String KEY_MARK="mark";
	public static final int MARK_COLUMN = 3;
	public static final String KEY_DIF="dif";
	public static final int DIF_COLUMN = 4;
	public static final String KEY_TYPE="type";
	public static final int TYPE_COLUMN = 5;
	
	// SQL Statement to create a new database.
	private static final String DATABASE_CREATE = "create table " + DATABASE_TABLE + " (" + KEY_ID + " integer primary key autoincrement, " +
			KEY_NAME + " text, " + KEY_DATE + " text, " + KEY_MARK + " text, " + KEY_DIF + " text, " + KEY_TYPE + " text)";
	
	private static final String[] allColumns = new String[]{KEY_ID, KEY_NAME, KEY_DATE, KEY_MARK, KEY_DIF, KEY_TYPE};
	
	/**
	 * Converts all data in database into csv file, located in the SD card
	 * @return the number of rows added, or -1 for "IOException", or -2 for another exception
	 */
	public int ConvertToCsv(){
		List<Mark> list = getAllMarks();
		try 
		{			
			FileWriter sw = new FileWriter(Environment.getExternalStorageDirectory() + "/" + MainActivity.resources.getString(R.string.app_name) + ".csv");
			for(int i = 0; i < list.size(); i++){
				sw.write(list.get(i).toString(",") + "\n");
		    }
			sw.close();
			return list.size();
		} 
		catch (java.io.IOException e)
		{
			return -1;
		}
		catch (Exception e)
		{
			return -2;
		}
	}
	
	public DatabaseHandler(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
    }
	
	@Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL(DATABASE_CREATE);
    }
	
	@Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + DATABASE_TABLE);
        onCreate(db);
    }
	/**
	 * Add row to database.
	 * @param grade - the mark from which to add
	 * @return the place of new row
	 */
	public long addGrade(Mark grade) {
	    SQLiteDatabase db = this.getWritableDatabase();
	 
	    ContentValues values = new ContentValues();
	    values.put(KEY_NAME, grade.GetFullName());
	    values.put(KEY_DATE, grade.getDate().toString());
	    values.put(KEY_MARK, grade.getMark());
	    values.put(KEY_DIF, grade.getDifficulty());
	    values.put(KEY_TYPE, grade.getType());
	    long place = db.insert(DATABASE_TABLE, null, values);
	    db.close(); 
	    return place;
	}
	
	/**
	 * Get the mark tow in the place
	 * @param id - the place
	 * @return the mark stored there
	 */
	public Mark getGrade(long id) {
	    SQLiteDatabase db = this.getReadableDatabase();
	 
	    Cursor cursor = db.query(DATABASE_TABLE, allColumns, KEY_ID + "=?",
	            new String[] { String.valueOf(id) }, null, null, null, null);
	    if (cursor != null)
	        cursor.moveToFirst();
	 
	    Mark grade = new Mark(Integer.parseInt(cursor.getString(ID_COLUMN)), cursor.getString(NAME_COLUMN),
	    			 cursor.getString(DATE_COLUMN), Integer.parseInt(cursor.getString(MARK_COLUMN)), cursor.getString(DIF_COLUMN), cursor.getString(TYPE_COLUMN));
	    return grade;
	}
	
	/**
	 * Get all rows in database
	 * @return list of all marks
	 */
	public List<Mark> getAllMarks() {
	    List<Mark> markList = new ArrayList<Mark>();
	    String selectQuery = "SELECT  * FROM " + DATABASE_TABLE;
	 
	    SQLiteDatabase db = this.getReadableDatabase();
	    Cursor cursor = db.rawQuery(selectQuery, null);
	    if (cursor.moveToFirst()) {
	        do {
	        	Mark grade = new Mark(Integer.parseInt(cursor.getString(ID_COLUMN)), cursor.getString(NAME_COLUMN),
		    			 cursor.getString(DATE_COLUMN), Integer.parseInt(cursor.getString(MARK_COLUMN)), cursor.getString(DIF_COLUMN), cursor.getString(TYPE_COLUMN));
	        	markList.add(grade);
	        } while (cursor.moveToNext());
	    }
	    return markList;
	}
	
	/**
	 * Get average grade
	 * @return the average grade
	 */
	public double GetAverageMarks(){
	    int sum = 0;
	    List<Mark> list = getAllMarks();
	    for(int i = 0; i < list.size(); i++){
	    	sum += list.get(i).getMark();
	    }
	    return (list.size() == 0 ? 0 : Math.round((double)sum / list.size() * 100) / 100.0) ;
	}

	/**
	 * Clear the database
	 */
	public void RemoveAll(){
		SQLiteDatabase db = this.getWritableDatabase();
		db.delete(DATABASE_TABLE, null, null);
		db.close();
	}

	/**
	 * remove the grade from the table with the ID
	 * @param id the id of the grade
	 */
	public void removeGrade(long id)
	{
		SQLiteDatabase db = this.getWritableDatabase();
		db.delete(DATABASE_TABLE, KEY_ID + "=?",
	            new String[] { String.valueOf(id) });
		db.close();
	}
}