using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoorbeeldEnumerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity))
        {
            Debug.Log(hit.collider.gameObject.name);
            if(hit.collider.gameObject.tag == "Player")
            {
                hit.collider.gameObject.GetComponent<PlayerStats>().TakeDamage(10);
            } 
        }
        Debug.DrawRay(transform.position, transform.forward, Color.red);
        
    }
}
