using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buttonFunction : MonoBehaviour
{

    public Material regularMaterial;
    public Material glowingMaterial;

    public GameObject indicator;
    public GameObject indicator2;
    public GameObject indicator3;
   
    public GameObject door;

    private void OnTriggerStay(Collider other)
    {
         door.SetActive(false);
         indicator.GetComponent<Renderer>().material = glowingMaterial;
         indicator2.GetComponent<Renderer>().material = glowingMaterial;
        indicator3.GetComponent<Renderer>().material = glowingMaterial;

    }

    private void OnTriggerExit(Collider other)
    {
        door.SetActive(true);
        indicator.GetComponent<Renderer>().material = regularMaterial;
        indicator2.GetComponent<Renderer>().material = regularMaterial;
        indicator3.GetComponent<Renderer>().material = regularMaterial;
    }

    static public void doorStop(GameObject door)
    {
        door.SetActive(true);
        Debug.Log("set active done");
    }
}
