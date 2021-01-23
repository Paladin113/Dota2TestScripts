using System;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using TMPro;
using System.Threading;

public class TriggerEndTest : MonoBehaviour
{
    [SerializeField] private GameObject endTest = null;
    [SerializeField] private GameObject backgroundGrey = null;
    [SerializeField] private GameObject test = null;
    [SerializeField] private GameObject nextQuestion = null;
    [SerializeField] private GameObject buttonPudge = null;
    [SerializeField] private GameObject endClassic = null;
    [SerializeField] private GameObject endArcade = null;
    [SerializeField] private ButtonDetails buttonDetails = null;
    [SerializeField] private Game game = null;
    [SerializeField] private XMLNRepetition xmlNRepetition = null;
    [SerializeField] private GameObject triggerWantAssessment = null;
    [SerializeField] private ButtonResurrect buttonResurrect = null;
    [SerializeField] private ArcadeMeneder arcadeMeneder = null;
    [SerializeField] private TextMeshProUGUI TextName = null;
    [SerializeField] private Text textMMRPlayer = null;
    [SerializeField] private Text textStreakRoundsInArcade = null;
    [SerializeField] private Text textStreakQuestionsInArcade = null;
    [SerializeField] private Text textTimeInArcade = null;
    [SerializeField] private Text textExtraLife = null;
    private bool flag = false;
    private int time = 0;

    private void Start()
    {
        xmlNRepetition.SaveNonRepetitionSystem();
        if (game.gameMode == "Classic")
        {

            if (game.bestMMRPlayerInClassic != null && game.bestTimeInClassic != null)
            {
                if (Int32.Parse(game.mMRPlayer) != Int32.Parse(game.bestMMRPlayerInClassic))
                {
                    if (Int32.Parse(game.mMRPlayer) > Int32.Parse(game.bestMMRPlayerInClassic))
                    {
                        game.loading.baseConnect.SendBaseThread();
                    }
                }
                else
                {
                    if (Int32.Parse(game.timeTest) < Int32.Parse(game.bestTimeInClassic))
                    {
                        game.loading.baseConnect.SendBaseThread();
                    }
                }
            }
            if (Int32.Parse(game.statsMaxMmrClassic) < Int32.Parse(game.mMRPlayer)) game.statsMaxMmrClassic = game.mMRPlayer;
            game.statsAverageMmrClassic = (Int32.Parse(game.statsAverageMmrClassic) + Int32.Parse(game.mMRPlayer)).ToString();
            game.statsGeneralTimeClassic = (Int32.Parse(game.statsGeneralTimeClassic) + Int32.Parse(game.timeTest)).ToString();
            game.statsPlayedOnceClassic = (Int32.Parse(game.statsPlayedOnceClassic) + 1).ToString();
            game.xmlData.SaveStats();

            endClassic.SetActive(true);
            if (game.stats.Where(x => x == 5).Count() < 10 && Int32.Parse(game.timeTest) > 30 && game.actualVersion != 0)
            {
                if (game.banOnName == true)
                {
                    int j = game.playerName.Length;
                    game.playerName = "";
                    for (int i = 0; i < j; i++)
                    {
                        if (i < 8) game.playerName += "*";
                    }
                }
                SendLeaderBoardThread();
                game.loading.baseConnect.SendBaseClassicThread(game.stats, Int32.Parse(game.mMRPlayer), Int32.Parse(game.timeTest));
                game.classicPassed = true;
                game.xmlData.SaveSetting();
            }
            if (game.ads)
            {
                if (triggerWantAssessment.activeSelf == false)
                {
                    Game.interstitialAd.Show();
                    game.LoadinInterstitialAd();
                }
                buttonDetails.rewardedAd = new RewardedAd(buttonDetails.inGameRewarded);
                buttonDetails.rewardedAd.OnAdClosed += buttonDetails.HandleRewardedAdClosed;
                buttonDetails.rewardedAd.OnUserEarnedReward += buttonDetails.HandleUserEarnedReward;
                buttonDetails.rewardedAd.OnAdLoaded += buttonDetails.HandleRewardedAdLoaded;
                buttonDetails.request = null;
                buttonDetails.request = new AdRequest.Builder().Build();
                buttonDetails.rewardedAd.LoadAd(buttonDetails.request);
                buttonDetails.showReward = false;
            }
            backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, 0);
            backgroundGrey.SetActive(true);
        }
        else if (game.gameMode == "Arcade")
        {
            if (game.bestMMRPlayerInArcade != null && game.bestTimeInArcade != null)
            {
                if (game.points * 140 != Int32.Parse(game.bestMMRPlayerInArcade))
                {
                    if (game.points * 140 > Int32.Parse(game.bestMMRPlayerInArcade))
                    {
                        game.loading.baseConnect.SendBaseThread();
                    }
                }
                else
                {
                    if (Int32.Parse(game.timeTest) < Int32.Parse(game.bestTimeInArcade))
                    {
                        game.loading.baseConnect.SendBaseThread();
                    }
                }
            }
            if (game.actualVersion != 0)
            {
                game.loading.baseConnect.SendBaseArcadeThread(game.stats, Int32.Parse(game.mMRPlayer), Int32.Parse(game.timeTest), Int32.Parse(game.streakInArcade), game.extraLife);
                if (game.mMRPlayer != "0")
                {
                    if (game.banOnName == true)
                    {
                        int j = game.playerName.Length;
                        game.playerName = "";
                        for (int i = 0; i < j; i++)
                        {
                            if (i < 8) game.playerName += "*";
                        }
                    }
                    SendLeaderBoardThread();
                }
            }
            if (game.playerName != "") TextName.text = game.playerName;
            textStreakRoundsInArcade.text = $"{((Int32.Parse(game.streakInArcade) - 1) / 15) + 1}";
            textStreakQuestionsInArcade.text = $"{((Int32.Parse(game.streakInArcade) - 1) % 15) + 1}";
            if (game.extraLife == "True") textExtraLife.text = "Да";
            else textExtraLife.text = "Нет";
            textTimeInArcade.text = $"{Int32.Parse(game.timeTest) / 60} м. {Int32.Parse(game.timeTest) % 60} с.";
            textMMRPlayer.text = $"{game.mMRPlayer} ММР";

            endArcade.SetActive(true);
            buttonResurrect.GetComponent<Button>().interactable = false;

            if (game.bestMMRPlayerInArcade != null && game.bestTimeInArcade != null)
            {
                if (game.points * 140 != Int32.Parse(game.bestMMRPlayerInArcade))
                {
                    if (game.points * 140 <= Int32.Parse(game.bestMMRPlayerInArcade))
                    {
                        arcadeMeneder.SoundTrueDeath();
                        arcadeMeneder.SoundLose();
                    }
                }
                else
                {
                    if (Int32.Parse(game.timeTest) > Int32.Parse(game.bestTimeInArcade))
                    {
                        arcadeMeneder.SoundTrueDeath();
                        arcadeMeneder.SoundLose();
                    }
                }
            }
            else
            {
                arcadeMeneder.SoundTrueDeath();
                arcadeMeneder.SoundLose();
            }

            if (Int32.Parse(game.statsMaxMmrArcade) < Int32.Parse(game.mMRPlayer)) game.statsMaxMmrArcade = game.mMRPlayer;
            game.statsAverageMmrArcade = (Int32.Parse(game.statsAverageMmrArcade) + Int32.Parse(game.mMRPlayer)).ToString();
            game.statsAverageRoundArcade = (Int32.Parse(game.statsAverageRoundArcade) + Int32.Parse(game.streakInArcade)).ToString();
            game.statsGeneralTimeArcade = (Int32.Parse(game.statsGeneralTimeArcade) + Int32.Parse(game.timeTest)).ToString();
            game.statsPlayedOnceArcade = (Int32.Parse(game.statsPlayedOnceArcade) + 1).ToString();
            game.xmlData.SaveStats();

            backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, 0);
            backgroundGrey.SetActive(true);           
        }
    }
    private void FixedUpdate()
    {
        if (game.gameMode == "Classic")
        {
            time++;
            if (time * 0.02 % 60 < 1.3)
            {
                game.GetComponent<ToggleSelect>().enabled = false;
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a + 0.03f);
            }
            else if (time * 0.02 % 60 > 1.3 && time * 0.02 % 60 < 2.6)
            {
                test.SetActive(false);
                if (triggerWantAssessment.activeSelf == true && game.actualVersion != 0)
                {
                    triggerWantAssessment.GetComponent<TriggerWantAssessment>().activeTrigger();
                }
                else
                {
                    endTest.SetActive(true);
                }
                nextQuestion.SetActive(false);
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a - 0.03f);
            }
            else if (time * 0.02 % 60 > 2.6)
            {
                if (triggerWantAssessment.activeSelf == true && game.actualVersion != 0)
                {
                    buttonPudge.SetActive(true);
                }
                else
                {
                    backgroundGrey.SetActive(false);
                }
                gameObject.SetActive(false);
            }
        }
        else if (game.gameMode == "Arcade")
        {

            time++;
            if (time * 0.02 % 60 < 1.3)
            {
                game.GetComponent<ToggleSelect>().enabled = false;
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a + 0.03f);
            }
            else if (time * 0.02 % 60 > 1.3 && time * 0.02 % 60 < 2.6)
            {
                if (game.ads && flag == false)
                {
                    flag = !flag;
                    if (triggerWantAssessment.activeSelf == false)
                    {
                        Game.interstitialAd.Show();
                        game.LoadinInterstitialAd();
                    }
                }
                test.SetActive(false);
                endTest.SetActive(true);
                nextQuestion.SetActive(false);
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a - 0.03f);
            }
            else if (time * 0.02 % 60 > 2.6)
            {               
                backgroundGrey.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }

    private void SendLeaderBoard()
    {
        if (game.gameMode == "Classic")
        {
            LeaderBoardManager.AddPlayerClassicToLeaderBoard(game.playerName, game.deviceId, int.Parse(game.mMRPlayer), int.Parse(game.timeTest));
        }
        else if (game.gameMode == "Arcade")
        {
            LeaderBoardManager.AddPlayerArcadeToLeaderBoard(game.playerName, game.deviceId, int.Parse(game.mMRPlayer), int.Parse(game.timeTest));
        }
    }


    public void SendLeaderBoardThread()
    {
        Thread thread = new Thread(SendLeaderBoard);
        thread.Start();
    }
}
