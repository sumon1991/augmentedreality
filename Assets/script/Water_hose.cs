using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_hose : MonoBehaviour {
   // public ParticleSystem particle_water;
    public ParticleEmitter particle_water,particle_water2;
    public int i;
    // Use this for initialization
    void Start () {
        

        particle_water.emit = false;
        particle_water2.emit = false;

              
    }
	
	// Update is called once per frame
	/*void Update () {
        if (Input.GetButtonDown("HosePiperToggleBtn"))
        {
            particle_water.emit = true;
            particle_water2.emit = true;
        }

    }*/

    

    

    public void HosePiperToggleBtn() {

        particle_water.emit = true;
        particle_water2.emit = true;

        /*if (particle_water && particle_water2) {wateropen(); } else { wateroff(); }*/
           
        //paricle_water2.Play();

    }
   /* IEnumerable wateropen()
    {
        particle_water.emit = true;
        particle_water2.emit = true;
        yield return new WaitForSeconds(2);
        particle_water.emit = false;
        particle_water2.emit = false;
        
    }
    public void wateroff() {

        particle_water.emit = false;
        particle_water2.emit = false;
    }*/
}
