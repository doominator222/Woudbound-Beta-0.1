using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorPuzzle : MonoBehaviour
{
    public static bool OnOff;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (OnOff == true)
        {
            OnOff = false;
        }
        else if (OnOff == false)
        {
            OnOff = true;
        }
    }
    
}
