using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript2 : MonoBehaviour
{
//    public Transform holdPos;
//    public Transform camRot;
   bool holding = false;
   public GameObject player;
   public Transform holdposition;

   void OnTriggerStay(Collider other)
   {
    if(Input.GetKeyDown(KeyCode.E))
    {
        if(other.gameObject.tag == "canPickUp")
        {
            if (holding == false)
            {
                holding = true;
                other.gameObject.transform.position = new Vector3(0, 1, 0);
                other.gameObject.transform.position = holdposition.position;
                other.gameObject.transform.parent = player.transform;
                Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), player.GetComponent<Collider>(), true);
            }
            else if (holding == true)
            {
                if (Input.GetKeyDown(KeyCode.Space) && PlayerMovement.canMove && PlayerMovement.characterController.isGrounded)
                {
                    PlayerMovement.moveDirection.y = PlayerMovement.jumpPower;
                }
                holding = false;
                other.gameObject.transform.parent = null;
                Physics.IgnoreCollision(other.gameObject.GetComponent<Collider>(), player.GetComponent<Collider>(), false);
            }
        } 
    }
   }
}
