using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderscript : MonoBehaviour {

    int score = 100;
     void OnTriggerEnter(Collider other)
    {
        Debug.Log(score++);
    }
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
