using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buttonPress2 : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    public GameObject objecttospawn; 
    private GameObject spawnedobject;
    public Transform spawnpoint;


   void OnTriggerStay(Collider other)
   {
        if(other.gameObject.tag.Equals(playerTag))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                spawnNew();
                Debug.Log("Player has pressed button.");
            }
        }
   }


    void spawnNew()
    {
        if(spawnedobject != null)
        {
        Destroy(spawnedobject);
        }
        spawnedobject = Instantiate(objecttospawn, spawnpoint.position, spawnpoint.rotation); 
    }

}
