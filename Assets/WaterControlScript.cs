using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
[RequireComponent(typeof(SpriteRenderer))]
public class WaterControlScript : MonoBehaviour {
    [SerializeField] MeshRenderer target;
   SpriteRenderer srend;
    ButtonManager button;
    public ParticleEmitter particle_water, particle_water2;

    // Use this for initialization
    void Start () {

        particle_water.emit = false;
        particle_water2.emit = false;

    }
   void Awake()
    {
        srend = GetComponent<SpriteRenderer>();
       
    }

    void OnMouseDown()
    {
        particle_water.emit = true;
        particle_water2.emit = true;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
