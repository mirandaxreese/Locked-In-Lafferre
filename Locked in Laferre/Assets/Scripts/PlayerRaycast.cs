using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour {

    public float distanceToSee;
    RaycastHit whatIHit;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out whatIHit, distanceToSee) && Input.GetButton("Fire1"))
        {
            Debug.Log("I touched something " + whatIHit.collider.gameObject.name);
            //if(whatIHit.collider.gameObject.GetComponent</*name of script*/>().)
        }
	}
}
