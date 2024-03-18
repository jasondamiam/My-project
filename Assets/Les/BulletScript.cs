using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed;
    public Camera fpsCam;

    public enum BulletType
    {
        BULLET,
        ROCKET,
        LAZERPEWPEW
    }

    public BulletType type;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Debug.Log("Object Destroyed");
    }
}
