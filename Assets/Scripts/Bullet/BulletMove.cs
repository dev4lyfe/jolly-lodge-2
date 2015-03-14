using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

	public float bulletSpeed;


	// Use this for initialization
	void Start () {
		 
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward);
	}

	void OnTriggerEnter (Collider other)
	{
		//dodamage other
		Destroy (gameObject);
	}
}
