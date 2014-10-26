using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	public float health, sanity, fatigue, maxSanity, maxHealth, maxFatigue;
	public Text healthDisplay, sanityDisplay, fatigueDisplay;

	public float GetHealth () {return health;}
	public float GetSanity () {return sanity;}
	public float GetFatigue () {return fatigue;}


}
