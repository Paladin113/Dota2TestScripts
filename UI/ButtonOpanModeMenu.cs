﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpanModeMenu : MonoBehaviour
{
    [SerializeField] GameObject open = null;
    [SerializeField] GameObject close = null;
    [SerializeField] GameObject blackout50 = null;
    [SerializeField] private AudioClip audioClip = null;
    [SerializeField] private Game game = null;

    public void OpanClose()
    {
        game.AudioManager(audioClip);
        blackout50.SetActive(true);
        open.SetActive(true);
        close.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
