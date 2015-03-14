using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	//NOTES

	/*
	a cool mechanics would be if the trigger value changed strength of a grip or push action, or drawing back bow


	 */

	public GameObject arrow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			Instantiate(arrow, gameObject.transform.position, arrow.transform.rotation);
		}

		if (Input.GetKey (KeyCode.JoystickButton0)) {
			//xbox controller A
		}

		//Input.GetAxis ("Axis3"); //right trigger


	}
}
