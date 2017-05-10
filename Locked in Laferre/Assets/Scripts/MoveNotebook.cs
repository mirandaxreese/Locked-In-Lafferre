using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNotebook : MonoBehaviour {

    Vector3 movement;

	// Use this for initialization
	void Start () {
        movement = new Vector3(44.32f, transform.position.y, transform.position.z);
	}
	
	public void collision()
    {
        transform.position = movement;
    }
}
