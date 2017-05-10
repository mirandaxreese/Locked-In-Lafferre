using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPuzzle2 : MonoBehaviour {

    // Declares the two states for the lightswitch: on or off.
    public GameObject Box;

    private enum State
    {
        on,
        off
    }

    // Declares the State as state.
    private State state;

    void Start()
    {
        state = SwitchPuzzle2.State.off;

    }

    // On the mouse up event, the state changes to off if it was on before clicked, and
    // the state changes to on if it was off before clicked.
    public void collision()
    {
        if (state == SwitchPuzzle2.State.on)
            TurnOff();
        else
            TurnOn();
    }

    // Turn on subprocedure: plays the TurnOn Animation, sets the state to on, and enables
    // the light.
    private void TurnOn()
    {
        GetComponent<Animation>().Play("TurnOnAnimation");
        state = SwitchPuzzle2.State.on;
        Box.GetComponent<MoveBox>().changeValue(2, 1);
    }

    //Turn off subprocedure: plays the TurnOff Animation, sets the state to off, and
    // disables the light.
    private void TurnOff()
    {
        GetComponent<Animation>().Play("TurnOffAnimation");
        state = SwitchPuzzle2.State.off;
        Box.GetComponent<MoveBox>().changeValue(2, 0);

    }
}
