using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class onbuttonClick : MonoBehaviour {

    //public ParticleSystem fireball;
    public ParticleEmitter water;
    //Place fireball prefab
    public float speed = 200.0f;

    public void OnMouseDown()
    {

        //water.transform.position = new Vector3((float)UnityEngine.Random.Range(-4, 4), 10.0f, (float)UnityEngine.Random.Range(3, 13));
       // fireball.Play();
        water.Emit();

    }
}
