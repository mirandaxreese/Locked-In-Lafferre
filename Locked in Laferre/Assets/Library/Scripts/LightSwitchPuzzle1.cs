using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchPuzzle1 : MonoBehaviour {

    // Declares the light game object as "DragYourLightHere".
    // Do not try to drag your light from unity into the actual script.
    // It is named like this so that the Unity editor will display where to
    // drag your light.
    public GameObject DragYourLightHere;

    // Declares the two states for the lightswitch: on or off.
    private enum State
    {
        on,
        off
    }

    // Declares the State as state.
    private State state;

    // Initializes the lightswitch so that the script knows the lights are off to
    // start with.
    void Start()
    {
        state = LightSwitchPuzzle1.State.off;

    }

    // On the mouse up event, the state changes to off if it was on before clicked, and
    // the state changes to on if it was off before clicked.
    public void collision()
    {
        Debug.Log("I flipped the switch.");
        if (state == LightSwitchPuzzle1.State.on)
            TurnOff();
        else
            TurnOn();
    }

    // Turn on subprocedure: plays the TurnOn Animation, sets the state to on, and enables
    // the light.
    private void TurnOn()
    {
        GetComponent<Animation>().Play("TurnOnAnimation");
        state = LightSwitchPuzzle1.State.on;
        DragYourLightHere.SetActive(true);

    }

    //Turn off subprocedure: plays the TurnOff Animation, sets the state to off, and
    // disables the light.
    private void TurnOff()
    {
        GetComponent<Animation>().Play("TurnOffAnimation");
        state = LightSwitchPuzzle1.State.off;
        DragYourLightHere.SetActive(false);

    }
}
