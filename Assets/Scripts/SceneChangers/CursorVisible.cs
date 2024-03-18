using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisible : MonoBehaviour
{
    void Awake()
    {
        Cursor.visible = true;

    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
