using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFiling : MonoBehaviour {

    Vector3 movement;

    // Use this for initialization
    void Start()
    {
        movement = new Vector3(transform.position.x, 2.496f , transform.position.z);
    }

    public void collision()
    {
        transform.position = movement;
    }
}
