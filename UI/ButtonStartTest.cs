using System;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class ButtonStartTest : MonoBehaviour
{
    [SerializeField] private GameObject modeMenu = null;
    [SerializeField] private GameObject searhElement = null;
    [SerializeField] private GameObject imageButtonStartClassic = null;
    [SerializeField] private GameObject imageButtonStartArcade = null;
    [SerializeField] private GameObject textSearchTime = null;
    [SerializeField] private GameObject blackout50 = null;
    [SerializeField] private Text imageSearchText = null;
    [SerializeField] private Text image1Text1 = null;
    [SerializeField] private Text image2Text1 = null;
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject searchArcade = null;
    [SerializeField] private GameObject searchClassic = null;
    [SerializeField] public GameObject textPatch = null;
    [SerializeField] public AudioClip mipMap = null;
    [NonSerialized] public Button[] buttons;
    private int time = 0;

    public void OnTextPatch()
    {
        textPatch.SetActive(true);
    }
    public void OffTextPatch()
    {
        textPatch.SetActive(false);
    }
    public void StartTest(string mode)
    {
        if (game.ads)
        {
            game.LoadinInterstitialAd();
        }
        game.gameMode = mode;
        if (mode == "Classic")
        {
            searchArcade.SetActive(false);
            if (game.bestMMRPlayerInClassic != null && game.bestPlayerInClassic != "") searchClassic.SetActive(true);
            imageSearchText.text = $"РЕЙТИНГОВЫЙ ТЕСТ / РЕГИОНЫ 3";
            image1Text1.text = "РЕЙТИНГОВЫЙ ТЕСТ";
            image2Text1.text = "РЕЙТИНГОВЫЙ ТЕСТ";
            imageButtonStartClassic.SetActive(true);
        }
        else if (mode == "Arcade")
        {
            if (game.bestPlayerInArcade != null && game.bestPlayerInArcade != "") searchArcade.SetActive(true);
            searchClassic.SetActive(false);
            imageSearchText.text = $"АРКАДА / РЕГИОНЫ 3";
            image1Text1.text = "АРКАДА";
            image2Text1.text = "АРКАДА";
            imageButtonStartArcade.SetActive(true);
        }

        textSearchTime.GetComponent<Text>().text = "0:00";
        textSearchTime.GetComponent<SearchTime>().time = 0;
        time = 0;
        buttons = modeMenu.GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
            button.interactable = false;
    }

    private void FixedUpdate()
    {
        if (game.gameMode == "Classic")
        {
            if (imageButtonStartClassic.gameObject.activeSelf == true)
            {
                time++;
                if (time > 50)
                {
                    blackout50.SetActive(false);
                    searhElement.SetActive(true);
                    textPatch.SetActive(false);
                    imageButtonStartClassic.SetActive(false);
                    time = 0;
                    modeMenu.SetActive(false);
                }
            }
        }
        else if (game.gameMode == "Arcade")
        {
            if (imageButtonStartArcade.gameObject.activeSelf == true)
            {
                time++;
                if (time > 50)
                {
                    blackout50.SetActive(false);
                    searhElement.SetActive(true);
                    textPatch.SetActive(false);
                    imageButtonStartArcade.SetActive(false);
                    time = 0;
                    modeMenu.SetActive(false);
                }
            }
        }

    }
}
