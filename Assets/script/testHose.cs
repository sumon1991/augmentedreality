using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class testHose : MonoBehaviour {

    public ParticleEmitter fireball, fireball2;		//Place fireball prefab
    public float speed = 200.0f;

    public void OnMouseDown()
    {
        Debug.Log("Working");

        //fireball.transform.position = new Vector3((float)UnityEngine.Random.Range(-4, 4), 10.0f, (float)UnityEngine.Random.Range(3, 13));
        fireball.Emit();
        fireball2.Emit();
    }

    

    
}
