using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgWhenTouched : MonoBehaviour
{

    public AudioSource hurtSound;

    void Start()
    {
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("bulletHit"))
        {
            hurtSound.Play();
            GetComponent<PlayerStats>().TakeDamage(25);
        }
    }
}
