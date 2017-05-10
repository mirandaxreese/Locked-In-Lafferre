using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBox : MonoBehaviour {

    int switch1, switch2, switch3, switch4;
    Vector3 start, end;

	// Use this for initialization
	void Start () {
        switch1 = switch2 = switch3 = switch4 = 0;
        start = transform.position;
        end = new Vector3(25.56f, transform.position.y, -98.14f);
	}
	
	// Update is called once per frame
	void Update () {
        if (switch1 == 1 && switch2 == 0 && switch3 == 1 && switch4 == 1)
        {
            transform.position = end;
        }else
        {
            transform.position = start;
        }
	}

    public void changeValue(int switches, int value)
    {
        if (switches == 1)
        {
            switch1 = value;
            Debug.Log("Switch" + switches + " value " + value);
        }
        else if (switches == 2)
        {
            switch2 = value;
        }
        else if (switches == 3)
        {
            switch3 = value;
        }
        else if (switches == 4)
        {
            switch4 = value;
        }
        Debug.Log("Switch" + switches + " value " + value);
    }
}
