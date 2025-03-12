using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class objectRewind : MonoBehaviour
{



public float maxRewindDuration = 10f;
    public float rewindSpeed = 2f;
  
    public List<TimeSnapshot> timeSnapshots = new List<TimeSnapshot>();

    void Start()
    {
        gameObject.GetComponent<Rigidbody> ().useGravity = true;
    }

    public struct TimeSnapshot
    {
        public Vector3 position;
        public Quaternion rotation;


        public TimeSnapshot(Vector3 pos, Quaternion rot)
        {
            position = pos;
            rotation = rot;
        }
    }

    private void FixedUpdate()
    {
        if(ControlPlayback.isRewinding == false)
        {
            StopRewind();
            RecordSnapshot();
        }


        if(ControlPlayback.isRewinding == true)
        {
            RewindTime();
        }
    }


    private void RecordSnapshot()
    {
        timeSnapshots.Insert(0, new TimeSnapshot(transform.position, transform.rotation));


        if (timeSnapshots.Count > Mathf.Round(maxRewindDuration / Time.fixedDeltaTime))
        {
            timeSnapshots.RemoveAt(timeSnapshots.Count - 1);
        }
    }


    public void RewindTime()
    {
        if (timeSnapshots.Count > 0)
        {
            TimeSnapshot snapshot = timeSnapshots[0];
            gameObject.GetComponent<Rigidbody> ().useGravity = false;
            transform.position = snapshot.position;
            transform.rotation = snapshot.rotation;


            timeSnapshots.RemoveAt(0);
        }
        else
        {
            StopRewind();
        }
    }

     public void StopRewind()
    {
        gameObject.GetComponent<Rigidbody> ().useGravity = true;
        ControlPlayback.isRewinding = false;
    }
}






