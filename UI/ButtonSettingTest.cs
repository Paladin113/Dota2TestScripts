using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSettingTest : MonoBehaviour
{
    [SerializeField] private GameObject extraMenu = null;
    [SerializeField] private GameObject profile = null;
    [SerializeField] private AudioClip audioAboutTest = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private Button buttonNoAds = null;
    [SerializeField] private Button buttonStats = null;
    [SerializeField] private Button buttonBackTest = null;
    [SerializeField] private GameObject backgroundMainMenu = null;
    [SerializeField] private GameObject test = null;
    [SerializeField] private GameObject buttonRestart = null;
    [SerializeField] private GameObject textNumberingQuestions = null;
    [SerializeField] private Game game = null;

    public void SettingTest()
    {
        game.AudioManager(audioAboutTest);
        buttonRestart.SetActive(true);
        textNumberingQuestions.SetActive(false);
        extraMenu.SetActive(true);
        buttonBackTest.gameObject.SetActive(true);
        backgroundMainMenu.SetActive(true);
        profile.SetActive(true);
        test.SetActive(false);
        blackout.gameObject.SetActive(true);
        if (game.ads) buttonStats.gameObject.SetActive(false);
        else buttonNoAds.gameObject.SetActive(false);
    }
}
