using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{

    public GameObject prefabToInstantiate;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            GameObject obj = Instantiate(prefabToInstantiate, playerTransform.forward, playerTransform.rotation);
            obj.transform.position = playerTransform.position * 1f;
        }
    }
}
