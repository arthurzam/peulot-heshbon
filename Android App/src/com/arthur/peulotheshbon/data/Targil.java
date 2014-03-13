package com.arthur.peulotheshbon.data;

import java.util.Random;

import com.arthur.peulotheshbon.*;

/**
 * a class to control the targil - 2 numbers, operation, and get the answer
 */
public class Targil {
	public int num1 = 0, peula = 0, num2 = 0;
	public boolean RangeType = true;
	
	/**
	 * get the peula as string
	 * @return the string
	 */
	public String GetPeulaString(){
		if(peula == 0) return "+";
		else if(peula == 1) return "-";
		else if(peula == 2) return "*";
		else if(peula == 3) return ":";
		else return "";
	}
	
	/**
	 * constructor
	 * @param peula the operation
	 * @param RangeType if it is including numbers less than 0
	 */
	public Targil(int peula, boolean RangeType) { 
		this.peula = peula; 
		this.RangeType = RangeType;
	}
	
	/**
	 * sets all the numbers from a random object
	 * @param r the random object
	 */
	public void RandomTheTargil(Random rnd){
		if(peula == 0){ // plus
			if(RangeType)
			{
				num1 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(10));
				num2 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(10));
			}
			else
			{
				num1 = (Data.chosenDifficulty + 1) * (rnd.nextInt(21) - 10);
				num2 = (Data.chosenDifficulty + 1) * (rnd.nextInt(10));
			}
		}
		else if(peula == 1){ // minus
			if(RangeType)
			{
				num1 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(10));
				num2 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(num1));
			}
			else
			{
				num1 = (Data.chosenDifficulty + 1) * (rnd.nextInt(21) - 10);
				num2 = (Data.chosenDifficulty + 1) * (rnd.nextInt(11));
			}
		}
		else if(peula == 2){ // multi
			if(RangeType)
			{
				num1 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(10));
				num2 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(10));
			}
			else
			{
				num1 = (Data.chosenDifficulty + 1) * (rnd.nextInt(20) - 10);
				num2 = (Data.chosenDifficulty + 1) * (rnd.nextInt(10));
			}
		}
		else if(peula == 3){ // divide
			if(RangeType)
			{
				num2 = (Data.chosenDifficulty + 1) * (1 + rnd.nextInt(11));
				num1 = num2 * (1 + rnd.nextInt(11));
			}
			else
			{
				num2 = (Data.chosenDifficulty + 1) * ((rnd.nextBoolean() ? -1 * rnd.nextInt(11) - 1 : rnd.nextInt(11) + 1));
				num1 = num2 * (rnd.nextBoolean() ? -1 * (rnd.nextInt(10) + 1) : rnd.nextInt(10) + 1);
			}
		}
	}
	
	/**
	 * converts to string "[num1] [operation] [num2] = "
	 */
	@Override
	public String toString() {
		String N1 = num1 + "", N2 = num2 + "";
		if(num1 < 0)
			N1 = "(" + num1 + ")";
		if(num2 < 0)
			N2 = "(" + num2 + ")";
		return N1 + " " + GetPeulaString() + " " + N2 + " = ";
	}
	
	/**
	 * gets the right answer
	 * @return the right answer
	 */
	public int GetRightAnswer(){
		if(peula == 0) return num1 + num2;
		else if(peula == 1) return num1 - num2;
		else if(peula == 2) return num1 * num2;
		else if(peula == 3) return num1 / num2;
		else return -1;
	}
}
