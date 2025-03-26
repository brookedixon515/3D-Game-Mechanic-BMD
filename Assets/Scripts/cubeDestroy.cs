using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDestroy : MonoBehaviour
{
    [SerializeField] string cubeTag = "Destroying";
    bool playeron;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playeron = true;
        }

          if(other.gameObject.tag.Equals(cubeTag) && playeron == false && ControlPlayback.isRewinding == false)
        {
            Invoke("destroyOther", 10);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            playeron = false;
        }
    }


    void destroyOther()
    {      if(playeron == false && ControlPlayback.isRewinding == false)
        {
        if ((transform.childCount > 0))
        {
        Transform childTransform = transform.Find("Playerbody"); 
        childTransform.parent = null; 
        }
         Destroy(gameObject);
        }
    }
        
    
    }


