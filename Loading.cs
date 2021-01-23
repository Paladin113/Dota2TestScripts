using System;
using System.Collections.Generic;
using UnityEngine.Video;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using TMPro;
using System.IO;
using System.Threading;

public class Loading : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private ModeMenu modeMenu = null;
    [SerializeField] private ButtonAcceptTest buttonAcceptTest = null;    
    [SerializeField] private Animator animator1 = null;
    [SerializeField] private Animator animator2 = null;
    [SerializeField] private Animator animator3 = null;
    [SerializeField] private Animator animator4 = null;
    [SerializeField] private RuntimeAnimatorController acpIcon = null;
    [SerializeField] private RuntimeAnimatorController acpTextLoaded = null;
    [SerializeField] private GameObject newUpdateAvailable = null;
    [SerializeField] private GameObject loading = null;
    [SerializeField] private Material materialGrayscale = null;
    [SerializeField] private Button buttonArcade = null;
    [SerializeField] private ToggleSound toggleSound = null;
    [SerializeField] private ToggleMusic toggleMusic = null;
    [SerializeField] private ToggleVideoInMainMenu toggleVideoInMainMenu = null;
    [SerializeField] private Image imageBestPlayerInArcade = null;
    [SerializeField] private ParticleSystem miniCircleInArcade = null;
    [SerializeField] private GameObject triggerWantAssessment = null;
    [SerializeField] private GameObject startNewPlayer1 = null;
    [SerializeField] private GameObject updateInfo = null;
    [SerializeField] private GameObject searchClassic = null;
    [SerializeField] private GameObject searchArcade = null;
    [SerializeField] private GameObject arcadeMeneger = null;
    [SerializeField] private TextMeshProUGUI textDeveloperMessage = null;
    [SerializeField] private Text textNotConnect = null;
    [SerializeField] private GameObject promptInModeMenu = null;
    [SerializeField] private Text textProfileName1 = null;
    [SerializeField] private Text textProfileName2 = null;
    [SerializeField] private Image imageBackground = null;
    

    [SerializeField] private Image buttinImageMedalClassic = null;
    [SerializeField] private Text textMedalClassic = null;
    [SerializeField] private Text textMmrClassic = null;
    [SerializeField] private Image buttinImageMedalArcade = null;
    [SerializeField] private Text textMedalArcade = null;
    [SerializeField] private Text textMmrArcade = null;

    [SerializeField] private TextMeshProUGUI textNameArcade = null;
    [SerializeField] private Text textLoaded = null;
    [SerializeField] private Text textBestStreakRoundsInArcade = null;
    [SerializeField] private Text textBestStreakQuestionsInArcade = null;
    [SerializeField] private Text textExtraLife = null;
    [SerializeField] private Text textBestTimeInArcade = null;
    [SerializeField] private Text textBestMMRPlayerInArcade = null;
    [SerializeField] private Text textBestPlayerInArcadeMainMenu = null;

    [SerializeField] private GameObject bestPlayerUnderButtonClassic = null;
    [SerializeField] private GameObject bestPlayerUnderButtonArcade = null;
    [SerializeField] private TextMeshProUGUI textNameClassic = null;
    [SerializeField] private Text textBestTimeInClassic = null;
    [SerializeField] private Text textBestMMRPlayerInClassic = null;
    [SerializeField] private Text textBestPlayerInClassicMainMenu = null;
    [SerializeField] private Text textBan = null;
    [SerializeField] private Text textBanOnName = null;
    [SerializeField] private Text textComponents = null;
    [SerializeField] private ButtonPlayOfflineAnimation buttonPlayOfflineAnimation = null;
    [SerializeField] public VideoPlayer videoMainMenu = null;
    [SerializeField] public XMLNRepetition xmlNRepetition = null;
    [SerializeField] public BaseConnect baseConnect = null;
    public List<Questions> questions = new List<Questions>();
    public bool playOffline = false;

    private bool[] components = new bool[14];
    private int sumComponents;
    private bool flag1 = false;
    private bool flag2 = true;
    private int time;
    private int timeHelp;
    private int timeOnLoadVideo;

    public class SortByName : IComparer<Questions>
    {
        public int Compare(Questions x, Questions y)
        {
            if (x.repeated > y.repeated)
                return 1;
            else if (x.repeated < y.repeated)
                return -1;
            else
                return 0;
        }
    }

    private void Start()
    {
        Game.id = -1;
        BaseQuestions baseQuestions = new BaseQuestions();
        questions = baseQuestions.BaseActive();
        if (Game.startWhith == "Arcade")
        {
            imageBackground.color = new Color(0.102f, 0.110f, 0.157f, 1.000f);
            game.gameMode = "Arcade";
        }
        else if (Game.startWhith == "Classic")
        {
            imageBackground.color = new Color(0.102f, 0.110f, 0.157f, 1.000f);
            game.gameMode = "Classic";
        }
        game.numberOfQuestions = questions.Count;
        game.nonRepetitionSystemArray = xmlNRepetition.LoadNonRepetitionSystem();
        BaseQuestionsWorkThread();
        game.deviceId = SystemInfo.deviceUniqueIdentifier;
        game.settingString = game.xmlData.LoadSetting();
        game.xmlData.LoadStats();
        if (game.settingString.Count != 0)
        {
            if (game.settingString.Count >= 1) toggleSound.SetSound(Boolean.Parse(game.settingString[0]));
            if (game.settingString.Count >= 2) toggleMusic.SetMusic(Boolean.Parse(game.settingString[1]));
            if (game.settingString.Count >= 3) game.touch = Boolean.Parse(game.settingString[2]);
            if (game.settingString.Count >= 4) game.newPlayer = Boolean.Parse(game.settingString[3]);
            if (game.settingString.Count >= 5) game.versionGame = game.settingString[4];
            else game.versionGame = "ERROR";
            if (game.settingString.Count >= 6) game.classicPassed = Boolean.Parse(game.settingString[5]);
            if (game.settingString.Count >= 7) game.promptInModeMenu = Boolean.Parse(game.settingString[6]);
            if (game.settingString.Count >= 8)
            {
                toggleVideoInMainMenu.SetVideoSetting(Boolean.Parse(game.settingString[7]));
                game.videoInGameMenu = Boolean.Parse(game.settingString[7]);
            }
            if (game.settingString.Count >= 9) game.languageMenu = game.settingString[8];
            if (game.settingString.Count >= 10) game.languageSounds = game.settingString[9];
        }
        if(game.languageSounds == "")
        {
            game.languageSounds = "RU";
        }
        arcadeMeneger.SetActive(true);
        if (game.videoInGameMenu == false)
        {
            videoMainMenu.gameObject.SetActive(false);
        }

        if (game.classicPassed == false)
        {
            modeMenu.arcadeText = "Чтобы открыть аркаду, нужно пройти рейтинговый тест.";
            buttonArcade.GetComponent<AudioSource>().clip = modeMenu.GetComponent<ButtonStartTest>().mipMap;
            buttonArcade.GetComponent<Image>().material = materialGrayscale;
            imageBestPlayerInArcade.color = new Color(1, 1, 1);
            var main = miniCircleInArcade.main;
            main.startColor = new Color(1, 1, 1);
        }
        else
        {
            buttonArcade.onClick.AddListener(delegate { SwitchButtonHandler("Arcade"); });
        }
        if (game.playerName != "")
        {
            textProfileName1.text = game.playerName;
            textProfileName2.text = game.playerName;
        }
        baseConnect.GetStatsThread();
        GetLeaderBoardClassicThread();
        GetLeaderBoardArcadeThread();
    }

    void SwitchButtonHandler(string idx_)
    {
        modeMenu.GetComponent<ButtonStartTest>().StartTest(idx_);
    }

    private void FixedUpdate()
    {
        timeHelp++;
        time++;
        if (game.t1.Count != 0 && game.t2.Count != 0 && game.t3.Count != 0 && game.t4.Count != 0 && game.t5.Count != 0 && flag2 == true)
        {
            xmlNRepetition.SaveNonRepetitionSystem();
            game.gameObject.SetActive(true);
            flag2 = false;
        }
        if (sumComponents >= 14 && flag1 == true)
        {
            timeOnLoadVideo++;
            OnHints();
            if (game.actualVersion > game.versionGameInNumbers)
            {
                PlayOffline();
                gameObject.SetActive(false);
                return;
            }
            if (game.promptInModeMenu == true)
            {
                promptInModeMenu.SetActive(true);
            }
            for (int i = 0; i < game.banList.Length; i++)
            {
                if (SystemInfo.deviceUniqueIdentifier == game.banList[i])
                {
                    game.ban = true;
                    textBan.gameObject.SetActive(true);
                    PlayOffline();
                    gameObject.SetActive(false);
                    return;
                }
            }
            for (int i = 0; i < game.banListOnName.Length; i++)
            {
                if (SystemInfo.deviceUniqueIdentifier == game.banListOnName[i])
                {
                    game.banOnName = true;
                    textBanOnName.gameObject.SetActive(true);
                }
            }
            buttinImageMedalArcade.gameObject.SetActive(true);
            buttinImageMedalClassic.gameObject.SetActive(true);

            if (game.bestPlayerInClassic != "")
            {
                bestPlayerUnderButtonClassic.SetActive(true);
                searchClassic.SetActive(true);
            }
            if (game.bestPlayerInArcade != "")
            {
                bestPlayerUnderButtonArcade.SetActive(true);
                searchArcade.SetActive(true);
            }
            textBestPlayerInArcadeMainMenu.gameObject.SetActive(true);
            textBestPlayerInArcadeMainMenu.text = game.bestPlayerInArcade;
            textNameArcade.text = game.bestPlayerInArcade;
            textBestStreakRoundsInArcade.text = $"{((Int32.Parse(game.bestStreakInArcade) - 1) / 15) + 1}";
            textBestStreakQuestionsInArcade.text = $"{((Int32.Parse(game.bestStreakInArcade) - 1) % 15) + 1}";
            if (game.bestExtraLife == "True") textExtraLife.text = "Да";
            else textExtraLife.text = "Нет";
            textBestTimeInArcade.text = $"{Int32.Parse(game.bestTimeInArcade) / 60} м. {Int32.Parse(game.bestTimeInArcade) % 60} с.";
            textBestMMRPlayerInArcade.text = $"{game.bestMMRPlayerInArcade} ММР";

            textBestPlayerInClassicMainMenu.gameObject.SetActive(true);
            textBestPlayerInClassicMainMenu.text = game.bestPlayerInClassic;
            textNameClassic.text = game.bestPlayerInClassic;
            textBestTimeInClassic.text = $"{Int32.Parse(game.bestTimeInClassic) / 60} м. {Int32.Parse(game.bestTimeInClassic) % 60} с.";
            textBestMMRPlayerInClassic.text = $"{game.bestMMRPlayerInClassic} ММР";

            if (game.developerMessage != "")
            {
                textDeveloperMessage.gameObject.SetActive(true);
                textDeveloperMessage.text = game.developerMessage;
            }


            if (videoMainMenu.isPrepared && game.videoInGameMenu == true)
            {
                animator1.enabled = true;
                animator2.runtimeAnimatorController = acpIcon;
                animator3.runtimeAnimatorController = acpTextLoaded;
                animator4.runtimeAnimatorController = acpTextLoaded;
                if (game.playerName != "") SetMedal();              
                if (Game.startWhith == "Arcade" || Game.startWhith == "Classic")
                {                                     
                    buttonAcceptTest.MakeTest();
                    loading.SetActive(false);
                }
                else
                {
                    Invoke("LoaddingOff", 1);
                }
                gameObject.SetActive(false);               
            }
            else if (game.videoInGameMenu == false || timeOnLoadVideo > 250)
            {
                videoMainMenu.gameObject.SetActive(false);
                animator1.enabled = true;
                animator2.runtimeAnimatorController = acpIcon;
                animator3.runtimeAnimatorController = acpTextLoaded;
                animator4.runtimeAnimatorController = acpTextLoaded;
                if (game.playerName != "") SetMedal();
                if (Game.startWhith == "Arcade" || Game.startWhith == "Classic")
                {
                    buttonAcceptTest.MakeTest();
                    loading.SetActive(false);
                }
                else
                {
                    Invoke("LoaddingOff", 1);
                }
                gameObject.SetActive(false);
            }
        }

        if (timeHelp == 10)
        {
            textLoaded.text = "Подключение к серверу.";
        }
        else if (timeHelp == 20)
        {
            textLoaded.text = "Подключение к серверу..";
        }
        else if (timeHelp == 30)
        {
            textLoaded.text = "Подключение к серверу...";
            timeHelp = 0;
        }

        if (game.actualVersion != 0) components[0] = true;
        if (game.bestStreakInArcade != null) components[1] = true;
        if (game.bestExtraLife != null) components[2] = true;
        if (game.bestTimeInArcade != null) components[3] = true;
        if (game.bestMMRPlayerInArcade != null) components[4] = true;
        if (game.bestPlayerInArcade != null) components[5] = true;
        if (game.bestPlayerInClassic != null) components[6] = true;
        if (game.bestTimeInClassic != null) components[7] = true;
        if (game.bestMMRPlayerInClassic != null) components[8] = true;
        if (game.banList != null) components[9] = true;
        if (game.banListOnName != null) components[10] = true;
        if (game.developerMessage != null) components[11] = true;
        if (game.classicLeaderBoards != null) components[12] = true;
        if (game.arcadeLeaderBoards != null) components[13] = true;

        sumComponents = 0;

        for (int i = 0; i < components.Length; i++)
        {
            if (components[i] == true) sumComponents++;
        }
        textComponents.text = $"Компонентов {sumComponents}/14";

        if (time % 250 == 0)
        {
            if (sumComponents < 13) baseConnect.GetStatsThread();
            GetLeaderBoardClassicThread();
            GetLeaderBoardArcadeThread();
        }
        if (playOffline == false && time > 250)
        {
            buttonPlayOfflineAnimation.gameObject.SetActive(true);
        }
        if (PurchaseManager.CheckBuyState("no__ads") == 2 || game.deviceId == "8ef213cb925629c74b012b4a3398e08f")
        {
            game.xmlData.DeliteKey();
            flag1 = true;
        }
        else if (PurchaseManager.CheckBuyState("no__ads") == 1 && game.deviceId != "8ef213cb925629c74b012b4a3398e08f")
        {
            game.xmlData.SaveKey();
            game.ads = false;
            flag1 = true;
        }
        else
        {
            flag1 = false;
        }
    }

    private void LoaddingOff()
    {
        loading.SetActive(false);
    }
    private void OnHints()
    {
        if (!File.Exists(Path.Combine(Application.persistentDataPath, "Settings.tpp")))
        {
            game.newPlayer = true;
            triggerWantAssessment.SetActive(true);
            startNewPlayer1.SetActive(true);
        }
        else
        {
            if (game.versionGame != Application.version || game.settingString.Count < 5 || game.newPlayer)
            {
                updateInfo.SetActive(true);
            }
        }
        game.versionGame = Application.version;
        string[] strs = game.versionGame.Split('.');
        game.versionGameInNumbers = Int32.Parse(strs[0] + strs[1] + strs[2]);
        if (game.actualVersion > game.versionGameInNumbers && !game.newUpdateWatch)
        {
            newUpdateAvailable.SetActive(true);
        }
    }

    private void CustomizationRepeated(List<Questions> t)
    {
        if (t[t.Count - 1].repeated != 0 && t[0].repeated == 0)
        {
            for (int i = 0; i < t.Count - 1; i++)
            {
                if (t[i].repeated == 0 && t[t.Count - 1].repeated != 1)
                {
                    game.nonRepetitionSystemArray[t[i].id] = t[t.Count - 1].repeated - 1;
                }
            }
        }
    }

    public void SetMedal()
    {
        if (game.classicLeaderBoards != null && game.arcadeLeaderBoards != null)
        {
            int positionInClassic = 0;
            int positionInArcade = 0;
            var temp = game.classicLeaderBoards.Where(x => x.deviceId == game.deviceId);

            if (temp.Count() != 0) positionInClassic = game.classicLeaderBoards.IndexOf(temp.First()) + 1;

            temp = game.arcadeLeaderBoards.Where(x => x.deviceId == game.deviceId);

            if (temp.Count() != 0) positionInArcade = game.arcadeLeaderBoards.IndexOf(temp.First()) + 1;

            double positionInClassicInPercent = 0;
            double positionInArcadeInPercent = 0;
            if (positionInClassic > 5) positionInClassicInPercent = (positionInClassic - 5.0) / (game.classicLeaderBoards.Count - 5);
            if (positionInArcade > 5) positionInArcadeInPercent = (positionInArcade - 5.0) / (game.arcadeLeaderBoards.Count - 5);

            if (positionInClassic != 0)
            {
                if (positionInClassic == 1)
                {
                    buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank8c_psd");
                    textMedalClassic.gameObject.SetActive(true);
                    textMedalClassic.text = positionInClassic.ToString();
                }
                else if (positionInClassic >= 2 && positionInClassic <= 5)
                {
                    buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank8b_psd");
                    textMedalClassic.gameObject.SetActive(true);
                    textMedalClassic.text = positionInClassic.ToString();
                }
                else if (positionInClassicInPercent <= 1.0 / 8)
                {
                    buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank8_psd");
                    textMedalClassic.gameObject.SetActive(true);
                    textMedalClassic.text = positionInClassic.ToString();
                }
                else if (positionInClassicInPercent >= 1.0 / 8 && positionInClassicInPercent <= 2.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank7_psd");
                else if (positionInClassicInPercent >= 2.0 / 8 && positionInClassicInPercent <= 3.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank6_psd");
                else if (positionInClassicInPercent >= 3.0 / 8 && positionInClassicInPercent <= 4.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank5_psd");
                else if (positionInClassicInPercent >= 4.0 / 8 && positionInClassicInPercent <= 5.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank4_psd");
                else if (positionInClassicInPercent >= 5.0 / 8 && positionInClassicInPercent <= 6.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank3_psd");
                else if (positionInClassicInPercent >= 6.0 / 8 && positionInClassicInPercent <= 7.0 / 8) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank2_psd");
                else if (positionInClassicInPercent >= 7.0 / 8 && positionInClassicInPercent <= 1) buttinImageMedalClassic.sprite = Resources.Load<Sprite>("Medal/rank1_psd");

                for (int i = 0; i < game.classicLeaderBoards.Count; i++)
                {
                    if (game.classicLeaderBoards[i].deviceId == game.deviceId) textMmrClassic.text = $"{game.classicLeaderBoards[i].rating} ммр";
                }
            }


            if (positionInArcade != 0)
            {
                if (positionInArcade == 1)
                {
                    buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank8c_psd");
                    textMedalArcade.gameObject.SetActive(true);
                    textMedalArcade.text = positionInArcade.ToString();
                }
                else if (positionInArcade >= 2 && positionInArcade <= 5)
                {
                    buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank8b_psd");
                    textMedalArcade.gameObject.SetActive(true);
                    textMedalArcade.text = positionInArcade.ToString();
                }
                else if (positionInArcadeInPercent <= 1.0 / 8)
                {
                    buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank8_psd");
                    textMedalArcade.gameObject.SetActive(true);
                    textMedalArcade.text = positionInArcade.ToString();

                }
                else if (positionInArcadeInPercent >= 1.0 / 8 && positionInArcadeInPercent <= 2.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank7_psd");
                else if (positionInArcadeInPercent >= 2.0 / 8 && positionInArcadeInPercent <= 3.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank6_psd");
                else if (positionInArcadeInPercent >= 3.0 / 8 && positionInArcadeInPercent <= 4.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank5_psd");
                else if (positionInArcadeInPercent >= 4.0 / 8 && positionInArcadeInPercent <= 5.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank4_psd");
                else if (positionInArcadeInPercent >= 5.0 / 8 && positionInArcadeInPercent <= 6.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank3_psd");
                else if (positionInArcadeInPercent >= 6.0 / 8 && positionInArcadeInPercent <= 7.0 / 8) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank2_psd");
                else if (positionInArcadeInPercent >= 7.0 / 8 && positionInArcadeInPercent <= 1) buttinImageMedalArcade.sprite = Resources.Load<Sprite>("Medal/rank1_psd");

                for (int i = 0; i < game.arcadeLeaderBoards.Count; i++)
                {
                    if (game.arcadeLeaderBoards[i].deviceId == game.deviceId) textMmrArcade.text = $"{game.arcadeLeaderBoards[i].rating} ммр";
                }
            }
        }
    }

    public void PlayOffline()
    {
        game.actualVersion = 0;
        game.bestStreakInArcade = null;
        game.bestExtraLife = null;
        game.bestTimeInArcade = null;
        game.bestMMRPlayerInArcade = null;
        game.bestPlayerInArcade = null;
        game.bestPlayerInClassic = null;
        game.bestTimeInClassic = null;
        game.bestMMRPlayerInClassic = null;
        game.banList = null;
        game.developerMessage = null;
        game.classicLeaderBoards = null;
        game.arcadeLeaderBoards = null;
        playOffline = true;
        if (game.ban == false) textNotConnect.gameObject.SetActive(true);
        if (game.actualVersion != game.versionGameInNumbers)
        {
            textNotConnect.text = "Скачайте обновление, чтобы подключиться к серверам";
        }
        animator1.enabled = true;
        animator2.runtimeAnimatorController = acpIcon;
        animator3.runtimeAnimatorController = acpTextLoaded;
        animator4.runtimeAnimatorController = acpTextLoaded;
        OnHints();
        if (Game.startWhith == "Arcade" || Game.startWhith == "Classic")
        {            
            buttonAcceptTest.MakeTest();
            loading.SetActive(false);
        }
        else
        {
            Invoke("LoaddingOff", 1);
        }
        gameObject.SetActive(false);
    }

    private void GetLeaderClassicBoard()
    {
        game.classicLeaderBoards = LeaderBoardManager.GetClassicLeaderBoard().ToList();
    }
    private void GetLeaderArcadeBoard()
    {
        game.arcadeLeaderBoards = LeaderBoardManager.GetArcadeLeaderBoard().ToList();
    }

    private void BaseQuestionsWork()
    {
        for (int i = 0; i < questions.Count; i++)
        {
            questions[i].repeated = game.nonRepetitionSystemArray[i];
        }
        System.Random rng = new System.Random();
        int n = questions.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Questions value = questions[k];
            questions[k] = questions[n];
            questions[n] = value;
        }

        SortByName comp = new SortByName();
        questions.Sort(comp);
        System.Random rnd = new System.Random();
        for (int i = 0; i < questions.Count; i++)
        {
            if (questions[i].tier == 1)
            {
                game.t1.Add(questions[i]);
                game.t1[game.t1.Count - 1].correctAnswer = rnd.Next(1, 5);
            }
            else if (questions[i].tier == 2)
            {
                game.t2.Add(questions[i]);
                game.t2[game.t2.Count - 1].correctAnswer = rnd.Next(1, 5);
            }
            else if (questions[i].tier == 3)
            {
                game.t3.Add(questions[i]);
                game.t3[game.t3.Count - 1].correctAnswer = rnd.Next(1, 5);
            }
            else if (questions[i].tier == 4)
            {
                game.t4.Add(questions[i]);
                game.t4[game.t4.Count - 1].correctAnswer = rnd.Next(1, 5);
            }
            else if (questions[i].tier == 5)
            {
                game.t5.Add(questions[i]);
                game.t5[game.t5.Count - 1].correctAnswer = rnd.Next(1, 5);
            }
        }
        CustomizationRepeated(game.t1);
        CustomizationRepeated(game.t2);
        CustomizationRepeated(game.t3);
        CustomizationRepeated(game.t4);
        CustomizationRepeated(game.t5);
    }


    public void GetLeaderBoardClassicThread()
    {
        Thread thread = new Thread(GetLeaderClassicBoard);
        thread.Start();
    }
    public void GetLeaderBoardArcadeThread()
    {
        Thread thread = new Thread(GetLeaderArcadeBoard);
        thread.Start();
    }

    public void BaseQuestionsWorkThread()
    {
        Thread thread = new Thread(BaseQuestionsWork);
        thread.Start();
    }
}
