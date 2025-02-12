using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayback : MonoBehaviour
{

 public static bool isRewinding = false;


  public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartRewind();
        }


        if (Input.GetKeyUp(KeyCode.R))
        {
            StopRewind();
        }
    }

    public void StartRewind()
    {
        isRewinding = true;
    }


    public void StopRewind()
    {
        isRewinding = false;
    }



}
