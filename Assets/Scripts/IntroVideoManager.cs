using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroVideoManager : MonoBehaviour
{
    public VideoPlayer introVideo;
    public GameObject mainMenu;
    public GameObject loadingScreen;
    public GameObject videoPlayer;

    void Update()
    {
        if((float)introVideo.time + 1.0 >= (float)introVideo.length)
        {
            videoPlayer.SetActive(false);
            mainMenu.SetActive(true);
            loadingScreen.SetActive(true);
        }
    }
}
