using System;
using System.Collections;
using System.Collections.Generic;
using FMODUnity;
using UnityEngine;
using STOP_MODE = FMOD.Studio.STOP_MODE;

public class EnterMainMenu : MonoBehaviour
{
    public GameObject MainMenu;
    private GameObject StartCanvas;
    public FMOD.Studio.EventInstance musicInstance;
    

    private void Start()
    {
        musicInstance = RuntimeManager.CreateInstance("event:/InGame/Level/BackgroundMusic");
        StartCanvas = GameObject.Find("StartCanvas");
        StopMusic();
        musicInstance.start();
    }

    private void Update()
    {
        ProcessInputs();
    }

    public void StopMusic()
    {
        musicInstance.stop(STOP_MODE.IMMEDIATE);
    }

    void ProcessInputs()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            MainMenu.SetActive(true);
            StartCanvas.SetActive(false);
        }
    }

}