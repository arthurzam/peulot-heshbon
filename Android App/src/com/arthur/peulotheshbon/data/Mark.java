package com.arthur.peulotheshbon.data;

import java.util.Date;

import com.arthur.peulotheshbon.Data;
import com.arthur.peulotheshbon.MainActivity;
import com.arthur.peulotheshbon.R;

/**
 * class represents a Mark row in the database
 * @author Arthur Zamarin
 */
public class Mark {
	private int id;
	private String name;
	private Date date;
	private int mark;
	private String difficulty;
	private String type;
	
	/**
	 * default constructor, everything is set to the defaults
	 */
	public Mark() {
		this.id = 0;
		this.name = "";
		this.date = new Date();
		this.mark = 0;
		this.difficulty = "Easy";
		this.type = "";
	}
	
	/**
	 * constructor
	 * @param id the id number of the row
	 * @param name the name of person
	 * @param date the date for represent
	 * @param mark the result of the check
	 * @param difficulty the difficulty
	 * @param type the quit type
	 */
	public Mark(int id, String name, Date date, int mark, String difficulty, String type) {
		
		this.id = id;
		this.name = name;
		this.date = date;
		this.mark = mark;
		this.difficulty = difficulty;
		this.type = type;
	}
	
	/**
	 * onstructor
	 * @param id
	 * @param name
	 * @param mark
	 * @param difficulty
	 * @param type
	 */
	public Mark(int id, String name, int mark, String difficulty, String type) {
		this.id = id;
		this.name = name;
		this.date = new Date();
		this.mark = mark;
		this.difficulty = difficulty;
		this.type = type;
	}
	
	public Mark(String type, int mark) {
		this.id = 0;
		this.name = Data.full_name;
		this.date = new Date();
		this.mark = mark;
		this.difficulty = MainActivity.resources.getStringArray(R.array.difficulty_entries)[Data.chosenDifficulty];
		this.type = type;		
	}
	
	public Mark(int id, String name, String date, int mark, String difficulty, String type) {
		this.id = id;
		this.name = name;
		this.date = new Date(date);
		this.mark = mark;
		this.difficulty = difficulty;
		this.type = type;
	}
	
	public Date getDate() {
		return date;
	}
	
	public String getDifficulty() {
		return difficulty;
	}
	
	public int getMark() {
		return mark;
	}
	
	public void setDate(Date date) {
		this.date = date;
	}
	
	public void setDifficulty(String difficulty) {
		this.difficulty = difficulty;
	}
	
	public void setMark(int mark) {
		this.mark = mark;
	}

	public int getId() {
		return id;
	}
	
	public void setId(int id) {
		this.id = id;
	}
	
	public String getType() {
		return type;
	}
	
	public void setType(String type) {
		this.type = type;
	}
	
	public String[] toStringArray(){
		return new String[]{name, date.toString(), type, difficulty ,mark + ""};
	}
	
	public String toString(String separetor){
		return name + separetor + toDateString() + separetor + toTimeString() + separetor + type + separetor + difficulty + separetor + mark;
	}
	
	public String GetFullName(){
		return name;
	}
	
	public void SetFullName(String full_name){
		this.name = full_name;
	}
	
	public String toDateString(){
		String[] s = date.toLocaleString().split(" ");
		return s[2] + " / " + s[1] + " / " + s[0];
	}
	
	public String toTimeString(){
		String[] s = date.toLocaleString().split(" ")[3].split(":");
		return s[0] + " : " + s[1];
	}
}