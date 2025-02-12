using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class buttonFunction : MonoBehaviour
{


    public GameObject door;

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(door);
    }
}
