using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour {

    public float distanceToSee;
    RaycastHit clue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.DrawRay(this.transform.position, this.transform.forward * distanceToSee, Color.magenta);

        if (Physics.Raycast(this.transform.position, this.transform.forward, out clue, distanceToSee) && Input.GetButtonDown("Fire1"))
        {
            if(clue.collider.tag == "Clues")
            {
                clue.collider.gameObject.SendMessageUpwards("collision");
            }
        }
	}
}
