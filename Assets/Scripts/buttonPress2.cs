using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buttonPress2 : MonoBehaviour
{
    [SerializeField] string playerTag = "Player";
    public GameObject objecttospawn; 
    public GameObject spawnedobject;
    public GameObject spawnedobject2;
    public Transform spawnpoint;
    public GameObject door2;
    public GameObject door3;

    public bool PlayerInside = false;
void Update()
{

        if(PlayerInside == true && Input.GetKeyDown(KeyCode.Q))
        {
            spawnNew();
             Debug.Log("Player has pressed button.");
        }

}

   void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.tag.Equals(playerTag))
        {
            PlayerInside = true;
        }
   }

void OnTriggerExit(Collider other)
{
    if(other.gameObject.tag.Equals(playerTag))
        {
            PlayerInside = false;
        }
}

    void spawnNew()
    {
        if(spawnedobject != null)
        {
            Destroy(spawnedobject);
        }
        if(spawnedobject2 != null)
        {
            Destroy(spawnedobject2);
        }
        buttonFunction.doorStop(door2);
        buttonFunction.doorStop(door3);
        Debug.Log("function called");
        spawnedobject = Instantiate(objecttospawn, spawnpoint.position, spawnpoint.rotation); 
        
    }

}
