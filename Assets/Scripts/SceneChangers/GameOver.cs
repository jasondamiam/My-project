using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public void respawn()
    {
        SceneManager.LoadScene(5);
    }

    public void exit()
    {
        SceneManager.LoadScene(0);
    }
}

