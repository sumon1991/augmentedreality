using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TrumpController : MonoBehaviour {

	private Rigidbody rb;
	private Animation anim;

	// Use this for initialization
	void Start () {
		
		//Creating Reference
		rb = GetComponent<Rigidbody> ();
		anim = GetComponent<Animation> ();

		
	}
	
	// Update is called once per frame
	void Update () {

		float x = CrossPlatformInputManager.GetAxis("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (Mathf.Clamp( x,-0.5f,0.5f), 0, 0) * Time.deltaTime;


        rb.MovePosition(transform.position + movement);


    /*//This is for 3d Movement
 
		rb.velocity = movement * 4f;

		if (x != 0 && y != 0) {
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2(x,y) * Mathf.Rad2Deg, transform.eulerAngles.z);
		}

     //This is for animation
     /*
		if (x != 0 || y != 0) {
		
			anim.Play ("Walk");
			
		} else {
		
			anim.Play ("idle");
		}
		*/
	}
}
