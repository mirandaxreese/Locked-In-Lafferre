using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            this.gameObject.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            playerCamera.GetComponent<CamMouseLook>().enabled = true;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
