using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathScore : MonoBehaviour {
    public GameObject player,childplayer;
    public GameObject enemy;
    int score = 100;
    


    void OnParticleCollision(GameObject childplayerr)
    {
        Debug.Log(score--);
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
