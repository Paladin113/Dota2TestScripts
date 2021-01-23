using UnityEngine;
using System;
using UnityEngine.UI;

public class ButtonCross : MonoBehaviour
{
    [SerializeField] private GameObject modeMenu = null;
    [SerializeField] private Button buttonArcadeStart = null;
    [SerializeField] private Button buttonClassicStart = null;   
    [SerializeField] private GameObject searhElement = null;
    [SerializeField] private AudioClip audioNextQuestion = null;
    [SerializeField] private GameObject textPatch = null;
    [SerializeField] private GameObject searchArcade = null;
    [SerializeField] GameObject blackout50 = null;
    [NonSerialized] public Button[] buttons;
    [SerializeField] private Game game = null;

    public void BackToMainManu()
    {
        game.AudioManager(audioNextQuestion);
        modeMenu.SetActive(true);
        buttons = modeMenu.GetComponentsInChildren<Button>(true);
        blackout50.SetActive(true);
        searchArcade.SetActive(false);
        foreach (Button button in buttons)
        {
            button.interactable = true;
        }
        buttonArcadeStart.gameObject.SetActive(true);
        buttonClassicStart.gameObject.SetActive(true);
        textPatch.SetActive(true);
        searhElement.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackToMainManu();
        }
    }
}
