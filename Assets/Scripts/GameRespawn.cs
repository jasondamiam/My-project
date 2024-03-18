using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRespawn : MonoBehaviour
{
    public float threshold;

    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
            GetComponent<PlayerStats>().TakeDamage(100);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("KingKong"))
        {
            GetComponent<PlayerStats>().TakeDamage(100);
        }
    }

}
