using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeDestroy : MonoBehaviour
{
    [SerializeField] string cubeTag = "Destroying";

  private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals(cubeTag) && other.gameObject.tag != "MainCamera")
        {
            Invoke("destroyOther", 8);
        }
        
    }

    void destroyOther()
    {
        Destroy(gameObject);
    }
        
    
    }


