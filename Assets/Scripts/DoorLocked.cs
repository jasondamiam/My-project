using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLocked : MonoBehaviour
{

    public AudioSource LockedAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            LockedAudio.Play();
        }
    }
}