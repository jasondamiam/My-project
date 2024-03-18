using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundonKey : MonoBehaviour
{
    public AudioSource key;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            key.Play();
        }
        
    }
}
