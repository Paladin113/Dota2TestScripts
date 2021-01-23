using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartNewPlayer : MonoBehaviour
{
    [SerializeField] private GameObject startNewPlayer2 = null;
    [SerializeField] GameObject newUpdateAvailable = null;
    [SerializeField] AudioClip audioClip = null;
    [SerializeField] private Game game = null;

    private void Start()
    {
        game.AudioManager(audioClip);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !newUpdateAvailable.activeSelf)
        {
            startNewPlayer2.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
