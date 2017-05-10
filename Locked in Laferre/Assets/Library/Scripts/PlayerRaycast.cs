using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRaycast : MonoBehaviour {

    public float distanceToSee;

    private bool key = false;

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
            } else if (clue.collider.tag == "Key")
            {
                key = true;
                Destroy(clue.collider.gameObject);
            } else if (clue.collider.tag == "Lock" && key)
            {
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(2);
            }
        }
	}
}
