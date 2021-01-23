using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;
using System.Collections.Generic;
using GoogleMobileAds.Api;
using System.Threading;

public class NextQuestion : MonoBehaviour
{

    [SerializeField] private GameObject triggerEndTest = null;
    [SerializeField] private GameObject textTimer = null;
    [SerializeField] private AudioClip audioNextQuestion = null;
    [SerializeField] private Game game = null;
    [SerializeField] private YouDied youDied = null;
    [SerializeField] private ButtonResurrect buttonResurrect = null;
    [SerializeField] private TextMeshProUGUI textTime = null;
    [SerializeField] public Toggle toggleAnswer1 = null;
    [SerializeField] public Toggle toggleAnswer2 = null;
    [SerializeField] public Toggle toggleAnswer3 = null;
    [SerializeField] public Toggle toggleAnswer4 = null;
    [SerializeField] public GameObject bestPlayer = null;
    [SerializeField] public Text textNumberingClassic = null;
    [SerializeField] public Text textNumberingRound = null;
    [SerializeField] public Text textNumberingQuestion = null;
    [NonSerialized] public bool resurrect = false;
    [NonSerialized] public bool lose = false;
    [NonSerialized] public int timeOnAnswers = 0;
    [NonSerialized] public DateTime dataPr1;
    [NonSerialized] public DateTime dataPr2;
    [NonSerialized] public DateTime timeEndQuestion;
    [NonSerialized] public DateTime timeStartQuestion;
    [NonSerialized] public int counter = 0;
    private bool next = false;
    private int timePr = 0;
    private double maxTimeArcade = 0;

    public static int answerTier = 0;

    private void FixedUpdate()
    {
        if (game.gameMode == "Classic")
        {
            if (next)
            {
                if (counter != 29)
                {
                    NextQ();
                    textNumberingClassic.text = $"{counter + 1} / 30";
                    next = !next;
                    if (counter == 29) gameObject.transform.Find("Text").GetComponent<Text>().text = "Завершить";
                }
                else
                {
                    game.timeEndTest = DateTime.Now;
                    TimeSpan timeTest = game.timeEndTest.Subtract(game.timeStartTest);
                    game.timeTest = ((int)timeTest.TotalSeconds).ToString();
                    InreractableAllToggles(false);
                    gameObject.GetComponent<Button>().interactable = false;
                    gameObject.GetComponent<NextQuestion>().enabled = false;
                    game.GetComponent<ToggleSelect>().enabled = false;
                    if (game.points * 140 != 9800) game.mMRPlayer = (game.points * 140).ToString();
                    else game.mMRPlayer = "10000";
                    CheckBestClassic();
                }
            }
        }
        else if (game.gameMode == "Arcade")
        {
            timePr++;
            dataPr2 = DateTime.Now;
            if (timePr % 50 == 0)
            {
                dataPr1 = DateTime.Now;
                timePr = 0;
            }
            if (Math.Abs(dataPr1.Subtract(dataPr2).TotalSeconds) > 1)
            {
                timeOnAnswers += (int)(Math.Abs(dataPr1.Subtract(dataPr2).TotalSeconds * 50));
                dataPr1 = DateTime.Now;
            }
            if (counter < 89) maxTimeArcade = 30.5 - (counter / 15) * 5;
            else maxTimeArcade = 3;


            if (lose == false)
            {

                if (maxTimeArcade - timeOnAnswers * 0.02 >= 0)
                {
                    textTime.text = $"{(int)(maxTimeArcade - timeOnAnswers * 0.02)}";
                }
                else textTime.text = "0";
            }
            timeOnAnswers++;
            if (!lose)
            {
                if (next)
                {
                    if (game.testQuestions[counter].numberAnswer != 1 || counter == 104)
                    {
                        lose = true;
                    }
                    else
                    {
                        timeEndQuestion = DateTime.Now;
                        TimeSpan timeTest = timeEndQuestion.Subtract(timeStartQuestion);
                        if (timeTest.TotalSeconds < 30) game.timeSecTest = game.timeSecTest + (int)timeTest.TotalSeconds;
                        else game.timeSecTest = game.timeSecTest + 30;
                        game.timeTest = game.timeSecTest.ToString();
                        timeStartQuestion = DateTime.Now;
                        NextQ();
                    }
                    next = !next;
                    timeOnAnswers = 0;
                }
            }
            else if (lose)
            {
                game.streakInArcade = (counter + 1).ToString();
                game.mMRPlayer = (game.points * 140).ToString();

                timeEndQuestion = DateTime.Now;
                TimeSpan timeTest = timeEndQuestion.Subtract(timeStartQuestion);
                if (timeTest.TotalSeconds < 30) game.timeSecTest = game.timeSecTest + (int)timeTest.TotalSeconds;
                else game.timeSecTest = game.timeSecTest + 30;
                game.timeTest = game.timeSecTest.ToString();
                timeStartQuestion = DateTime.Now;

                game.BlockQuestion(game.testQuestions[counter]);

                game.GetComponent<ToggleSelect>().enabled = false;
                gameObject.GetComponent<Button>().interactable = false;
                gameObject.GetComponent<NextQuestion>().enabled = false;
                if (((resurrect == false && game.actualVersion != 0) || (game.ads == false && resurrect == false)) && counter != 104)
                {
                    if (game.ads)
                    {
                        buttonResurrect.rewardedAd = new RewardedAd(buttonResurrect.inGameRewarded);
                        buttonResurrect.rewardedAd.OnAdClosed += buttonResurrect.HandleRewardedAdClosed;
                        buttonResurrect.rewardedAd.OnUserEarnedReward += buttonResurrect.HandleUserEarnedReward;
                        buttonResurrect.rewardedAd.OnAdLoaded += buttonResurrect.HandleRewardedAdLoaded;
                        buttonResurrect.request = null;
                        buttonResurrect.request = new AdRequest.Builder().Build();
                        buttonResurrect.rewardedAd.LoadAd(buttonResurrect.request);
                        buttonResurrect.showReward = false;
                    }
                    youDied.gameObject.SetActive(true);
                }
                else
                {
                    CheckBestArcade();
                }
            }
            if ((int)(maxTimeArcade - timeOnAnswers * 0.02) < 1 && next == false)
            {
                NextQuestions();
            }
        }
    }

    public void NextQ()
    {
        counter++;
        textNumberingQuestion.text = $"Вопрос { (counter % 15) + 1}";
        textNumberingRound.text = $"Круг {(counter / 15) + 1}";
        game.SetQuestion(game.testQuestions[counter]);
        if (game.testQuestions[counter].answers4 != "")
        {
            game.SetTogles(4);
        }
        else
        {
            game.SetTogles(3);
        }
        game.loading.xmlNRepetition.SaveNonRepetitionSystem();
    }

    private void Start()
    {
        if (game.gameMode == "Classic")
        {
            textNumberingClassic.gameObject.SetActive(true);
            textNumberingClassic.text = $"{counter + 1} / 30";
        }
        else if (game.gameMode == "Arcade")
        {
            dataPr1 = DateTime.Now;
            dataPr2 = DateTime.Now;
            timeStartQuestion = DateTime.Now;
            textNumberingQuestion.gameObject.SetActive(true);
            textNumberingRound.gameObject.SetActive(true);
            textTimer.SetActive(true);
            textNumberingQuestion.text = $"Вопрос {(counter % 15) + 1}";
            textNumberingRound.text = $"Круг {(counter / 15) + 1}";
        }
        if (game.testQuestions[0].answers4 != "")
        {
            game.SetTogles(4);
        }
        else
        {
            game.SetTogles(3);
        }
    }

    public void NextQuestions()
    {
        game.AudioManager(audioNextQuestion);
        if (game.testQuestions[counter].question != null)
        {
            int a = 0;
            if (toggleAnswer1.isOn)
            {
                a = game.testQuestions[counter].keys[0];
            }
            else if (toggleAnswer2.isOn)
            {
                a = game.testQuestions[counter].keys[1];
            }
            else if (toggleAnswer3.isOn)
            {
                a = game.testQuestions[counter].keys[2];
            }
            else if (toggleAnswer4.isOn)
            {
                a = game.testQuestions[counter].keys[3];
            }
            else
            {
                a = 5;
            }
            if (a == 1)
            {
                if (answerTier == 1)
                {
                    game.points++;
                }
                else if (answerTier == 2)
                {
                    game.points += 2;
                }
                else if (answerTier == 3)
                {
                    game.points += 3;
                }
                else if (answerTier == 4)
                {
                    game.points += 4;
                }
                else if (answerTier == 5)
                {
                    game.points += 5;
                }
            }
            if (toggleAnswer1.isOn)
            {
                game.testQuestions[counter].numberAnswer = a;
            }
            else if (toggleAnswer2.isOn)
            {
                game.testQuestions[counter].numberAnswer = a;
            }
            else if (toggleAnswer3.isOn)
            {
                game.testQuestions[counter].numberAnswer = a;
            }
            else if (toggleAnswer4.isOn)
            {
                game.testQuestions[counter].numberAnswer = a;
            }
            else
            {
                game.testQuestions[counter].numberAnswer = a;
            }
            game.stats[game.testQuestions[counter].id] = (byte)game.testQuestions[counter].numberAnswer;
            toggleAnswer1.isOn = false;
            toggleAnswer2.isOn = false;
            toggleAnswer3.isOn = false;
            toggleAnswer4.isOn = false;
        }
        else if(game.testQuestions[counter].question == null)
        {
            bool notRight = false;
            int c = 0;
            for (int i = 0; i < game.imagesForButtosQuestionsCraft.Length; i++)
            {
                for (int j = 0; j < game.testQuestions[counter].item.Craft.Count; j++)
                {
                    if(game.imagesForButtosQuestionsCraft[i] == null)
                    {
                        c = game.testQuestions[counter].item.Craft.Count;
                        break;
                    }
                    if (game.imagesForButtosQuestionsCraft[i].GetComponent<ButtonItem>().item.Name != game.testQuestions[counter].item.Craft[j].Name)
                    {
                        c++;
                    }
                }
                if(c == game.testQuestions[counter].item.Craft.Count)
                {
                    notRight = true;
                    break;
                }
                c = 0;
            }
            
            if (notRight == false)
            {
                game.testQuestions[counter].numberAnswer = 1;
                game.stats[game.testQuestions[counter].id] = 1;
                if (answerTier == 1)
                {
                    game.points++;
                }
                else if (answerTier == 2)
                {
                    game.points += 2;
                }
                else if (answerTier == 3)
                {
                    game.points += 3;
                }
                else if (answerTier == 4)
                {
                    game.points += 4;
                }
                else if (answerTier == 5)
                {
                    game.points += 5;
                }
            }
            else
            {
                game.testQuestions[counter].numberAnswer = 2;
                game.stats[game.testQuestions[counter].id] = 2;
            }
            game.testQuestions[counter].yourCraft = new List<Item>(game.imagesForButtosQuestionsCraft.Length);
            for (int i = 0; i < game.imagesForButtosQuestionsCraft.Length; i++)
            {
                if (game.imagesForButtosQuestionsCraft[i] == null)
                {
                    game.testQuestions[counter].yourCraft.Add(Items.pusto);
                }
                else
                {
                    game.testQuestions[counter].yourCraft.Add(game.imagesForButtosQuestionsCraft[i].GetComponent<ButtonItem>().item);
                }

            }
        }     
        next = true;
    }
    public void InreractableAllToggles(bool t)
    {
        if (t)
        {
            toggleAnswer1.interactable = true;
            toggleAnswer2.interactable = true;
            toggleAnswer3.interactable = true;
            toggleAnswer4.interactable = true;
        }
        else if (!t)
        {
            toggleAnswer1.interactable = false;
            toggleAnswer2.interactable = false;
            toggleAnswer3.interactable = false;
            toggleAnswer4.interactable = false;
        }

    }

    public void CheckBestArcade()
    {
        if (game.bestMMRPlayerInArcade != null && game.bestTimeInArcade != null)
        {
            if (Int32.Parse(game.mMRPlayer) != Int32.Parse(game.bestMMRPlayerInArcade))
            {
                if (Int32.Parse(game.mMRPlayer) <= Int32.Parse(game.bestMMRPlayerInArcade))
                {
                    triggerEndTest.SetActive(true);
                }
                else
                {
                    game.ActiveBlackout1100(bestPlayer);
                }
            }
            else
            {
                if (Int32.Parse(game.timeTest) > Int32.Parse(game.bestTimeInArcade))
                {
                    triggerEndTest.SetActive(true);
                }
                else
                {
                    game.ActiveBlackout1100(bestPlayer);
                }
            }
        }
        else
        {
            triggerEndTest.SetActive(true);
        }
    }
    public void CheckBestClassic()
    {
        if (game.bestMMRPlayerInClassic != null && game.bestTimeInClassic != null)
        {
            if (Int32.Parse(game.mMRPlayer) != Int32.Parse(game.bestMMRPlayerInClassic))
            {
                if (Int32.Parse(game.mMRPlayer) <= Int32.Parse(game.bestMMRPlayerInClassic))
                {
                    triggerEndTest.SetActive(true);
                }
                else
                {
                    game.ActiveBlackout1100(bestPlayer);
                }
            }
            else
            {
                if (Int32.Parse(game.timeTest) > Int32.Parse(game.bestTimeInClassic))
                {
                    triggerEndTest.SetActive(true);
                }
                else
                {
                    game.ActiveBlackout1100(bestPlayer);
                }
            }
        }
        else
        {
            triggerEndTest.SetActive(true);
        }
        
    }
}

