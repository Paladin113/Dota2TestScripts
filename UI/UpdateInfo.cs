using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateInfo : MonoBehaviour
{
    [SerializeField] private GameObject StartNewPlayer = null;
    [SerializeField] GameObject newUpdateAvailable = null;
    [SerializeField] AudioClip audioClip = null;
    [SerializeField] Game game = null;

    private void Start()
    {
        game.AudioManager(audioClip);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !newUpdateAvailable.activeSelf)
        {
            if(game.versionGame == "ERROR" || game.newPlayer)
            {
                game.versionGame = Application.version;
                StartNewPlayer.SetActive(true);
                
            }
            else
            {
                game.versionGame = Application.version;
                game.xmlData.SaveSetting();
            }
            gameObject.SetActive(false);

        }
    }
}
