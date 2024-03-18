using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoJumpScare : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;
    void Start()
    {
        videoPlayer.SetActive(false);
    }

    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }

}
