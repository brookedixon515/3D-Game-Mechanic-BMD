using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buttonFunction : MonoBehaviour
{


   
    public GameObject door;

    private void OnTriggerStay(Collider other)
    {
         door.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        door.SetActive(true);
    }

    static public void doorStop(GameObject door)
    {
        door.SetActive(true);
        Debug.Log("set active done");
    }
}
