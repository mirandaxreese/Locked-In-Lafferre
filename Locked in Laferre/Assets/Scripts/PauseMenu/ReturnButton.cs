using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnButton : MonoBehaviour {

    public GameObject playerCamera;
    public GameObject player;
    public GameObject menu;

    public void Resume()
    {
        GetComponent<Menu>().gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        playerCamera.GetComponent<CamMouseLook>().enabled = true;
        player.GetComponent<CharacterController>().enabled = true;
        menu.gameObject.SetActive(false);
    }
}
