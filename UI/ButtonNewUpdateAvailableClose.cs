using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonNewUpdateAvailableClose : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] GameObject newUpdateAvailable = null;
    [SerializeField] private AudioClip audioCloseUpdateAvailable = null;



    private void newUpdateAvailableSetActiveFalse()
    {

        newUpdateAvailable.SetActive(false);
    }

    public void PlaySound()
    {
        game.AudioManager(audioCloseUpdateAvailable);
    }
    public void NewUpdateAvailableClose()
    {
        Invoke("newUpdateAvailableSetActiveFalse", 0.05f);
        game.newUpdateWatch = true;
    }

    private void Start()
    {
        if (game.newUpdateWatch)
        {
            NewUpdateAvailableClose();
        }
    }
}
