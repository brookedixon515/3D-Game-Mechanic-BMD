using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueButtonFunction : MonoBehaviour
{
    public GameObject door;
    public bool doorOpen = true;
    [SerializeField] string canPickUp = "canPickUp";
    public GameObject flash; 

	
    		
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag.Equals(canPickUp))
        {
         door.SetActive(false);
         doorOpen = true; 
         Debug.Log("Door opened");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag.Equals(canPickUp))
        {
        doorOpen = false;
        StartCoroutine (DoorWait ());
        Debug.Log("Cube removed");
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
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(true);
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(false);
                yield return new WaitForSeconds(1.0f);
                flash.SetActive(true);
                yield return new WaitForSeconds(1.0f);
    			door.SetActive(true);
    		}

    	}
    
    static public void doorStop(GameObject door)
    {
        door.SetActive(true);
        Debug.Log("set active done");
    }

}