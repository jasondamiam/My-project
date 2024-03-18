using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgWhenTouched : MonoBehaviour
{

    public AudioSource hurtSound;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("RedObj"))
        {
            hurtSound.Play();
            GetComponent<PlayerStats>().TakeDamage(25);
        }
    }
}
