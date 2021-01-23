using System;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;


public class StartTest : MonoBehaviour
{
    [SerializeField] private Button buttonBackMenu = null;
    [SerializeField] private GameObject test = null;
    [SerializeField] private GameObject menu = null;
    [SerializeField] private GameObject backgroundMainMenu = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private GameObject BackgroundVideo = null;
    [SerializeField] private Game game = null;

    void Start()
    {              
        if (game.ads && game.gameMode == "Classic")
        {
            Game.interstitialAd.Show();
            game.LoadinInterstitialAd();
        }
        StartAllTest();
    }

    public void StartAllTest()
    {
        test.SetActive(true);
        menu.SetActive(false);
        BackgroundVideo.SetActive(false);
        backgroundMainMenu.transform.localScale = new Vector3(130f,130f,0);
        backgroundMainMenu.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("BackgroundTest");
        blackout.SetActive(false);
    }

    public void ActiveRightLeftButtons()
    {
        buttonBackMenu.gameObject.SetActive(true);
    }
}
