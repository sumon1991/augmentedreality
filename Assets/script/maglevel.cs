using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maglevel : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -5);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
