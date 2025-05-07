using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPlayback : MonoBehaviour
{
 public static bool isRewinding = false;

    public Slider timedurationslider; 
    int timeduration;
  

    void Start()
    {
        timeduration = 10;
        timedurationslider.maxValue = 10; 
    }

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

<<<<<<< Updated upstream
        
    
=======
    //     timedurationslider.value = timeduration;

    //     if(isRewinding)
    //     {
    //         if(timeduration > 0)
    //         {
    //         InvokeRepeating("sliderCounter", 1f);
    //         }
    //     }

    //     if(isRewinding == false)
    //     {
    //         if(timeduration > 10)
    //         {
    //         InvokeRepeating("sliderCounter2", 1f);
    //         }
    //     }
>>>>>>> Stashed changes
    }

    // IEnumerator sliderCounter()
    // {
    //     timeduration--;
    // }

    // IEnumerator sliderCounter2()
    // {
    //     timeduration++;
    // }

    public void StartRewind()
    {
        isRewinding = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
    }
}
