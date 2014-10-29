using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum DayOrNight {Day, Night};

public class Time : MonoBehaviour {

	public int day=0;
	public float minute=0;
	public Text dayDisplay, hourDisplay, minuteDisplay;
	
	void Start ()
	{
		StartCoroutine ("StartTime");
	}
	
	IEnumerator StartTime ()
	{
		while(true)
		{
			yield return new WaitForSeconds(0.1f);
			if (minute < 1439)
				//change display for minute
				minute++;
			else
			{
				//change display for minute, hour, and day
				day++;
				minute = 0;
			}
		}
	}

	void Update ()
	{
		dayDisplay.text = day.ToString ();
		hourDisplay.text = ReturnHour ().ToString();
		minuteDisplay.text = ReturnMinute ().ToString ();
	}

	public int ReturnMinute ()
	{
		return ((int)(minute % 60));
	}

	public int ReturnHour ()
	{
		return (Mathf.FloorToInt (minute / 60));
	}

	public DayOrNight ReturnDayOrNight()
	{
		if (ReturnHour() >= 7 && ReturnHour() <= 17)
			return DayOrNight.Day;
		else
			return DayOrNight.Night;
	}

	public void IncrementTime (float minutes)
	{
		if (minute + minutes >= 1440)
			day++;
		minute = ((minute+minutes) % 1440);
	}

}
