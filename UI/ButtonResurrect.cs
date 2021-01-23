using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class ButtonResurrect : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private AudioClip audioMango = null;
    [SerializeField] private AudioClip audioButtonResurrectClose = null;
    [SerializeField] private Button buttonResurrectClose = null;
    [SerializeField] private Button buttonResurrect = null;
    [SerializeField] private GameObject openAds = null;
    [SerializeField] private NextQuestion nextQuestion = null;
    [SerializeField] private GameObject blackout1100 = null;
    [SerializeField] private GameObject blackout1001 = null;
    [SerializeField] private YouDied youDied = null;
    [SerializeField] private Image hud = null;
    [SerializeField] private Sprite hudFull = null;
    [SerializeField] private Sprite hudNotFull = null;
    public bool showReward = false;
    public RewardedAd rewardedAd;
    public AdRequest request;
    private bool interactableButtons = true;
    ////Main
    [NonSerialized] public string inGameRewarded = "ca-app-pub-3015742885636577/8814450634";

    //Test
    //public readonly string inGameRewarded = "ca-app-pub-3940256099942544/5224354917";

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
        interactableButtons = false;
        hud.sprite = hudFull;
        youDied.AddMP(110);
        game.AudioManager(audioMango);
        game.extraLife = "True";
        if (youDied.hp > 100) youDied.hp = 100;
    }

    public void NoAdsResurrect()
    {
        interactableButtons = false;
        hud.sprite = hudFull;
        youDied.AddMP(110);
        game.AudioManager(audioMango);
        game.extraLife = "True";
        if (youDied.hp > 100) youDied.hp = 100;
    }

    public void PreResurrect()
    {
        blackout1100.SetActive(true);
        hud.sprite = hudNotFull;
        Invoke("Resurrect", 1.5f);
        youDied.enabled = false;
    }

    public void Resurrect()
    {
        nextQuestion.toggleAnswer1.transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2");
        nextQuestion.toggleAnswer2.transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2");
        nextQuestion.toggleAnswer3.transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2");
        nextQuestion.toggleAnswer4.transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2");
        nextQuestion.dataPr1 = DateTime.Now;
        nextQuestion.dataPr2 = DateTime.Now;
        nextQuestion.timeStartQuestion = DateTime.Now;
        nextQuestion.enabled = true;
        nextQuestion.textNumberingQuestion.text = $"Вопрос { (nextQuestion.counter % 15) + 1}";
        nextQuestion.textNumberingRound.text = $"Круг {(nextQuestion.counter / 15) + 1}";
        nextQuestion.resurrect = true;
        nextQuestion.lose = false;
        nextQuestion.timeOnAnswers = 0;
        nextQuestion.NextQ();

        

        game.GetComponent<ToggleSelect>().enabled = true;
        nextQuestion.GetComponent<Button>().interactable = true;
        blackout1001.SetActive(true);        
        Invoke("OffBlackout1001", 1);
        youDied.gameObject.SetActive(false);
        nextQuestion.InreractableAllToggles(true);


    }

    private void OffBlackout1001()
    {
        blackout1001.SetActive(false);
    }

    public void WaitAds()
    {
        openAds.SetActive(true);
        youDied.enabled = false;
        buttonResurrectClose.interactable = false;
        buttonResurrect.interactable = false;
    }

    public void DontWaitAds()
    {
        openAds.SetActive(false);
        youDied.enabled = true;
        buttonResurrectClose.interactable = true;
        buttonResurrect.interactable = true;
    }

    public void StartResurrect()
    {
        showReward = true;
        WaitAds();
    }

    public void ButtonResurrectClose()
    {
        interactableButtons = false;
        youDied.Died();
        game.AudioManager(audioButtonResurrectClose);
        nextQuestion.CheckBestArcade();
    }

    private void Start()
    {
        if(game.ads) buttonResurrect.onClick.AddListener(StartResurrect);
        else buttonResurrect.onClick.AddListener(NoAdsResurrect);

    }

    private void Update()
    {
        if(interactableButtons == false)
        {
            buttonResurrect.interactable = false;
            buttonResurrectClose.interactable = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && openAds.activeSelf == true)
        {
            rewardedAd.OnAdLoaded -= HandleRewardedAdLoaded;
            DontWaitAds();
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && openAds.activeSelf == false)
        {
            ButtonResurrectClose();
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
