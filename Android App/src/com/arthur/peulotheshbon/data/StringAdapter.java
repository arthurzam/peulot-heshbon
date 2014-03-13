package com.arthur.peulotheshbon.data;

import android.content.Context;
import android.view.Gravity;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewGroup.LayoutParams;
import android.widget.BaseAdapter;
import android.widget.GridView;
import android.widget.TextView;

/**
 * Acts as an adapter for TextView
 * 
 * @version 30/11/2012
 * @author Arthur
 */
public class StringAdapter extends BaseAdapter {
	private final Context m_Context;
	private final String[] array;

	/**
	 * constructor
	 * 
	 * @param c
	 *            the Context
	 * @param array
	 *            the string array
	 */
	public StringAdapter(Context c, String[] array) {
		this.m_Context = c;
		this.array = array;
	}

	/**
	 * returns the number of items
	 */
	@Override
	public int getCount() {
		return array.length;
	}

	/**
	 * return the item in a specific place
	 * 
	 * @param position
	 *            the place
	 */
	@Override
	public Object getItem(int position) {
		return array[position];
	}

	@Override
	public long getItemId(int arg0) {
		return 0;
	}

	/**
	 * returns the view
	 */
	@Override
	public View getView(int position, View convertView, ViewGroup parent) {
		TextView lb;
		if (convertView == null) {
			lb = new TextView(m_Context);
			lb.setPadding(3, 8, 3, 8);
			lb.setGravity(Gravity.CENTER);
			lb.setClickable(false);
			lb.setLongClickable(false);
			lb.setLayoutParams(new GridView.LayoutParams(
					LayoutParams.WRAP_CONTENT, LayoutParams.WRAP_CONTENT));
		} else {
			lb = (TextView) convertView;
		}
		lb.setText(array[position]);
		lb.setId(position);

		return lb;
	}

}
