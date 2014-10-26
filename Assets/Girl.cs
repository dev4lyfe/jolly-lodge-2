using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum Location {Kitchen, Bedroom, Livingroom, Outside};
public enum Activity {Sleeping, Cooking, Eating, Reading, Walking};
public enum Mood {Happy, Sad, Angry, Confused, Aroused};

public class Girl : MonoBehaviour {
	public Location currentLocation;
	public Activity currentActivity;
	public Mood currentMood;
	public float health, value, trust, maxHealth;
	public Text healthDisplay, valueDisplay, trustDisplay, activityDisplay, moodDisplay;

	public float GetHealth () {return health;}
	public float GetValue () {return value;}
	public float GetTrust () {return trust;}
	public Location GetCurrentLocation () {return currentLocation;}
	public Activity GetCurrentActivity () {return currentActivity;}

	public const string ACTIVITY_COOKING = "Cooking";
	public const string ACTIVITY_EATING = "Eating";
	public const string ACTIVITY_SLEEPING = "Sleeping";
	public const string ACTIVITY_READING = "Reading";
	public const string ACTIVITY_WALKING = "Walking";

	public const string MOOD_HAPPY = "Happy";
	public const string MOOD_SAD = "Sad";
	public const string MOOD_ANGRY = "Angry";
	public const string MOOD_CONFUSED = "Confused";
	public const string MOOD_AROUSED = "Aroused";
	public const string MOOD_METADATA = "Does this change the GUID";

	public void IncrementHealth (float healthValue)
	{
		health += healthValue;
		if (health > maxHealth)
			health = maxHealth;
	}

	public void DecrementHealth (float healthValue)
	{
		health -= healthValue;
		if (health < 0)
			health = 0;
	}

	public void IncrementTrust (float trustValue)
	{
		trust += trustValue;
	}
	
	public void DecrementTrust (float trustValue)
	{
		trust -= trustValue;
	}

	public void IncrementValue (float herValue)
	{
		value += herValue;
	}

	public void DecrementValue (float herValue)
	{
		value -= herValue;
	}

	public void SetLocation (Location location)
	{
		currentLocation = location;
	}

	public void SetMood (Mood mood)
	{
		currentMood = mood;
	}

	public void SetActivity (Activity activity)
	{
		currentActivity = activity;
	}	

	void Update()
	{
		//handle all of the displays
		healthDisplay.text = health.ToString ();
		trustDisplay.text = trust.ToString ();
		valueDisplay.text = value.ToString ();

		switch (currentActivity)
		{
		case Activity.Cooking : activityDisplay.text = ACTIVITY_COOKING; break;
		case Activity.Eating : activityDisplay.text = ACTIVITY_EATING; break;
		case Activity.Reading : activityDisplay.text = ACTIVITY_READING; break;
		case Activity.Sleeping : activityDisplay.text = ACTIVITY_SLEEPING; break;
		case Activity.Walking : activityDisplay.text = ACTIVITY_WALKING; break;
		}

		switch (currentMood)
		{
		case Mood.Angry : moodDisplay.text = MOOD_ANGRY; break;
		case Mood.Aroused : moodDisplay.text = MOOD_AROUSED; break;
		case Mood.Confused : moodDisplay.text = MOOD_CONFUSED; break;
		case Mood.Happy : moodDisplay.text = MOOD_HAPPY; break;
		case Mood.Sad : moodDisplay.text = MOOD_SAD; break;
		}

	}
}
