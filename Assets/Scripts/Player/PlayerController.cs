using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public GameObject arrow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			Instantiate(arrow, gameObject.transform.position, arrow.transform.rotation);
		}
	}
}
