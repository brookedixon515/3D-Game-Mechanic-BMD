using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButtonFunction : MonoBehaviour
{
    public GameObject door;
    public bool doorOpen = true;
    [SerializeField] string canPickUp = "canPickUp";
    public GameObject flash; 

    public Material regularMaterial;
    public Material glowingMaterial;
    public GameObject indicator;

    public GameObject indicator2;
    public GameObject indicator3;
   
   

	
    		
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag.Equals(canPickUp))
        {
         door.SetActive(false);
         doorOpen = true; 
         Debug.Log("Door opened");
        indicator.GetComponent<Renderer>().material = glowingMaterial;
        indicator2.GetComponent<Renderer>().material = glowingMaterial;
        indicator3.GetComponent<Renderer>().material = glowingMaterial;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals(canPickUp))
        {
        doorOpen = false;
        StartCoroutine (DoorWait ());
        Debug.Log("Cube removed");
        indicator.GetComponent<Renderer>().material = regularMaterial;
        indicator2.GetComponent<Renderer>().material = regularMaterial;
        indicator3.GetComponent<Renderer>().material = regularMaterial;
        }
    }
    
    	IEnumerator DoorWait()
    	{
            Debug.Log("DoorWait ran");
    		if (doorOpen == false) 
            {
                door.SetActive(false);
    			yield return new WaitForSeconds(1.0f);
                flash.SetActive(false);
                indicator.GetComponent<Renderer>().material = regularMaterial;
                indicator2.GetComponent<Renderer>().material = regularMaterial;
                indicator3.GetComponent<Renderer>().material = regularMaterial;
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(true);
                indicator.GetComponent<Renderer>().material = glowingMaterial;
                indicator2.GetComponent<Renderer>().material = glowingMaterial;
                indicator3.GetComponent<Renderer>().material = glowingMaterial;
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(false);
                indicator.GetComponent<Renderer>().material = regularMaterial;
                indicator2.GetComponent<Renderer>().material = regularMaterial;
                indicator3.GetComponent<Renderer>().material = regularMaterial;
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(true);
                indicator.GetComponent<Renderer>().material = regularMaterial;
                indicator2.GetComponent<Renderer>().material = regularMaterial;
                indicator3.GetComponent<Renderer>().material = regularMaterial;
                yield return new WaitForSeconds(1.0f);
                indicator.GetComponent<Renderer>().material = regularMaterial;
                indicator2.GetComponent<Renderer>().material = regularMaterial;
                indicator3.GetComponent<Renderer>().material = regularMaterial;
    			door.SetActive(true);
    		}

    	}
    
    static public void doorStop(GameObject door)
    {
        door.SetActive(true);
        Debug.Log("set active done");
    }

}