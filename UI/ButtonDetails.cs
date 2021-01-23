using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class ButtonDetails : MonoBehaviour
{
    [SerializeField] private Button buttonRestart = null;
    [SerializeField] private Button buttonDetails = null;
    [SerializeField] private GameObject endDetails = null;
    [SerializeField] private AudioClip audioStartTest = null;
    [SerializeField] private GameObject portalEffect = null;
    [SerializeField] private GameObject openAds = null;
    [SerializeField] private Image imageButtonDetails = null;
    [SerializeField] private Text textButtonDetails = null;
    [SerializeField] private Game game = null;

    public bool showReward = false;
    public RewardedAd rewardedAd;
    public AdRequest request;
    //Main
    [NonSerialized] public string inGameRewarded = "ca-app-pub-3015742885636577/8814450634";

    //Test
    //private readonly string inGameRewarded = "ca-app-pub-3940256099942544/5224354917";

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        DontWaitAds();
    }

    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        DontWaitAds();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        game.startEnd = true;
        portalEffect.SetActive(false);
        buttonDetails.gameObject.SetActive(false);
        endDetails.SetActive(true);
    }

    public void WaitAds()
    {
        openAds.SetActive(true);
        buttonRestart.GetComponent<Button>().interactable = false;
        buttonDetails.GetComponent<Button>().interactable = false;
    }

    public void DontWaitAds()
    {
        openAds.SetActive(false);
        buttonRestart.GetComponent<Button>().interactable = true;
        buttonDetails.GetComponent<Button>().interactable = true;
    }

    private void Start()
    {
        if(!game.ads)
        {
            textButtonDetails.rectTransform.sizeDelta = new Vector2(0, 0);
            textButtonDetails.rectTransform.localPosition = new Vector3(0, 0, 0);
            imageButtonDetails.gameObject.SetActive(false);
        }
    }

    public void StartDetails()
    {       
        if (game.ads)
        {
            WaitAds();
            showReward = true;
        }
        game.AudioManager(audioStartTest);
        if (!game.ads)
        {
            game.startEnd = true;
            portalEffect.SetActive(false);
            gameObject.SetActive(false);
            endDetails.SetActive(true);
        }

    }

    private void Update()
    {
        if (game.ads)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                rewardedAd.OnAdLoaded -= HandleRewardedAdLoaded;
                DontWaitAds();
            }
            if (showReward)
            {
                if (rewardedAd.IsLoaded())
                {
                    rewardedAd.Show();
                    rewardedAd = new RewardedAd(inGameRewarded);
                    rewardedAd.OnAdClosed += HandleRewardedAdClosed;
                    rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
                    rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
                    request = null;
                    request = new AdRequest.Builder().Build();
                    rewardedAd.LoadAd(request);
                    showReward = false;
                }
            }
        }      
    }
}
