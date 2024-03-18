using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void play()
    {
        SceneManager.LoadScene(5);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Player has quit");
    }
}