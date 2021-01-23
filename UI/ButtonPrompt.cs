using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonPrompt : MonoBehaviour
{
    [SerializeField] Text textQuestion = null;
    [SerializeField] private AudioClip audioNextQuestion = null;
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject blackoutTest = null;
    [NonSerialized] public bool buttonPromptOn = false;
    [SerializeField] AudioClip audioClip = null;

    private void Start()
    {
        if (game.touch == false)
        {
            game.AudioManager(audioClip);
            blackoutTest.gameObject.SetActive(true);
            game.touch = true;
            game.xmlData.SaveSetting();
        }
    }

    public void ButtonPromptClick()
    {
        game.AudioManager(audioNextQuestion);
        if (buttonPromptOn)
        {
            textQuestion.text = game.testQuestions[game.numberQuestion].question;
            buttonPromptOn = !buttonPromptOn;
        }
        else
        {
            textQuestion.text = game.testQuestions[game.numberQuestion].about;
            buttonPromptOn = !buttonPromptOn;
        }
    }
}
