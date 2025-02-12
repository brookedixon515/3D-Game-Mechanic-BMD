using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnpoint;

    float spawnInterval = 10f;

   private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while(true)
        {
            if (objectToSpawn != null && spawnpoint != null)
            {
                Instantiate(objectToSpawn, spawnpoint.position, spawnpoint.rotation);
            }
            else
            {
                Debug.LogWarning("Object to spawn or spawn point is not set.");
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
