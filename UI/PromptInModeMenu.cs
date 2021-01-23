using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptInModeMenu : MonoBehaviour
{
    [SerializeField] AudioClip audioClip = null;
    [SerializeField] private Game game = null;
    [SerializeField] AnimetionModeMenuContent animetionModeMenuContent = null;

    private void Start()
    {
        animetionModeMenuContent.enabled = false;
        game.AudioManager(audioClip);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animetionModeMenuContent.enabled = true;
            game.promptInModeMenu = false;
            game.xmlData.SaveSetting();
            gameObject.SetActive(false);
        }
    }
}
