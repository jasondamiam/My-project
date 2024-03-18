using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneButtons : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene(5);
    }

    public void mainmenureturn()
    {
        SceneManager.LoadScene(0);
    }
}
