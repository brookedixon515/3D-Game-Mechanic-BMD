using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript2 : MonoBehaviour
{
    bool holding = false;
    private GameObject player;
    private Transform holdposition;
    private bool _inTrigger;
    private GameObject Playerbody;
    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        player =  GameObject.Find("Playerbody");
        holdposition = player.transform.Find("Main Camera/holdPosition");
    }
private void Update()
{
    if (holdposition == null)
    {
        Debug.Log("nuh uh");
    }
    if(_inTrigger)
    {   

      if(Input.GetKeyDown(KeyCode.E) && holding == false)
      {
            gameObject.transform.parent = player.transform;
            // rb.useGravity = false;

            holding = true;
      }
      else if(Input.GetKeyDown(KeyCode.E) && holding == true)
      {
            gameObject.transform.parent = null;
            // rb.useGravity = true;
            holding = false;
      }
    }
    
    if(holding)
    {
        gameObject.transform.position = holdposition.position;
    }
}

private void OnTriggerEnter(Collider other)
{
    if(other.gameObject.tag == "PickUp Collider")
    {
    _inTrigger = true;  
    Debug.Log("in trigger");
    }
}

private void OnTriggerExit(Collider other)
{
    if(other.gameObject.tag == "PickUp Collider")
    {
    _inTrigger = false;
    Debug.Log("out trigger");
    gameObject.transform.parent = null;
     gameObject.GetComponent<Rigidbody> ().useGravity = true;
    }
}
}