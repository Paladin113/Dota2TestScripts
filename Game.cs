using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using GoogleMobileAds.Api;

public class Game : MonoBehaviour
{
    [SerializeField] private Text question = null;
    [SerializeField] private Text answer1 = null;
    [SerializeField] private Text answer2 = null;
    [SerializeField] private Text answer3 = null;
    [SerializeField] private Text answer4 = null;
    [SerializeField] private Text text5MainSetting = null;
    [SerializeField] private Text textPatch = null;
    [SerializeField] private Text textFakePatch = null;
    [SerializeField] private Image imageQuestion = null;
    [SerializeField] private Image imageTextQuestion = null;
    [SerializeField] private GameObject test = null;
    [SerializeField] private GameObject buttonPrompt = null;
    [SerializeField] private Toggle toggleAnswer1 = null;
    [SerializeField] private Toggle toggleAnswer2 = null;
    [SerializeField] private Toggle toggleAnswer3 = null;
    [SerializeField] private Toggle toggleAnswer4 = null;
    [SerializeField] private Button buttonSoundQuestion = null;
    [SerializeField] private GameObject itemMenu = null;
    [SerializeField] private SpriteRenderer imageFrame = null;
    [SerializeField] public GameObject blackout1001 = null;
    [SerializeField] public GameObject blackout1100 = null;
    [SerializeField] public XMLData xmlData = null;
    [SerializeField] public string patch = null;
    [SerializeField] public Loading loading = null;
    [SerializeField] public Text prefabPlaceForItem = null;
    [SerializeField] public Button prefabButtonItem = null;
    [SerializeField] public Image prefabImageItemCraft = null;
    [SerializeField] public GameObject prefabImageBackItem = null;

    [NonSerialized] public Image[] imagesForBlockQuestion = null;
    [NonSerialized] public Button[] buttosForQuestion = null;
    [NonSerialized] public Text[] textForButtosQuestions = null;
    [NonSerialized] public GameObject[] imagesForButtosQuestions = null;
    [NonSerialized] public GameObject[] imagesForButtosQuestionsCraft = null;
    [NonSerialized] public ButtonItem[] buttonsItem = null;
    [NonSerialized] private GameObject gO;
    [NonSerialized] private List<Toggle> toggls = new List<Toggle>();
    [NonSerialized] public int points = 0;
    [NonSerialized] public int mmrr = 0;
    [NonSerialized] public int numberQuestion = 0;
    [NonSerialized] public bool startEnd = false;
    [NonSerialized] public bool ads = true;
    [NonSerialized] public byte[] stats = null;
    [NonSerialized] public string gameMode = "";
    [NonSerialized] public int versionGameInNumbers;
    [NonSerialized] public int actualVersion;
    [NonSerialized] public bool newUpdateWatch;

    [NonSerialized] public DateTime timeStartTest;
    [NonSerialized] public DateTime timeEndTest;
    [NonSerialized] public int timeSecTest = 0;

    [NonSerialized] public string playerName = "";
    [NonSerialized] public string streakInArcade = "0";
    [NonSerialized] public string timeTest = "";
    [NonSerialized] public string mMRPlayer = "";
    [NonSerialized] public string extraLife = "False";

    [NonSerialized] public string bestPlayerInArcade;
    [NonSerialized] public string bestStreakInArcade;
    [NonSerialized] public string bestTimeInArcade;
    [NonSerialized] public string bestMMRPlayerInArcade;
    [NonSerialized] public string bestExtraLife;
    [NonSerialized] public string bestPlayerInClassic;
    [NonSerialized] public string bestTimeInClassic;
    [NonSerialized] public string bestMMRPlayerInClassic;
    [NonSerialized] public string developerMessage;

    [NonSerialized] public string statsMaxMmrClassic = "0";
    [NonSerialized] public string statsAverageMmrClassic = "0";
    [NonSerialized] public string statsGeneralTimeClassic = "0";
    [NonSerialized] public string statsPlayedOnceClassic = "0";
    [NonSerialized] public string statsMaxMmrArcade = "0";
    [NonSerialized] public string statsAverageMmrArcade = "0";
    [NonSerialized] public string statsAverageRoundArcade = "0";
    [NonSerialized] public string statsGeneralTimeArcade = "0";
    [NonSerialized] public string statsPlayedOnceArcade = "0";




    [NonSerialized] public static int id;
    [NonSerialized] public static string startWhith;
    [NonSerialized] public string deviceId;

    [NonSerialized] public string versionGame = "";
    [NonSerialized] public bool updateinfo = true;
    [NonSerialized] public bool newPlayer = false;
    [NonSerialized] public bool musicSetting = true;
    [NonSerialized] public bool soundSetting = true;
    [NonSerialized] public bool touch = false;
    [NonSerialized] public bool classicPassed = false;
    [NonSerialized] public bool promptInModeMenu = true;
    [NonSerialized] public bool videoInGameMenu = true;
    [NonSerialized] public string languageSounds = "";
    [NonSerialized] public string languageMenu = "";



    [NonSerialized] public AudioSource audioSource = null;
    [NonSerialized] public bool ban = false;
    [NonSerialized] public bool banOnName = false;

    [NonSerialized] public List<PlayerInLeaderBoard> classicLeaderBoards;
    [NonSerialized] public List<PlayerInLeaderBoard> arcadeLeaderBoards;
    [NonSerialized] public Item[] itemsForQuestion = new Item[12];
    [NonSerialized] private string keyPurchase = null;
    [NonSerialized] public List<Questions> testQuestions = new List<Questions>();
    [NonSerialized] public List<Questions> t1 = new List<Questions>();
    [NonSerialized] public List<Questions> t2 = new List<Questions>();
    [NonSerialized] public List<Questions> t3 = new List<Questions>();
    [NonSerialized] public List<Questions> t4 = new List<Questions>();
    [NonSerialized] public List<Questions> t5 = new List<Questions>();
    [NonSerialized] public List<string> settingString = new List<string>();
    [NonSerialized] public string[] banList;
    [NonSerialized] public string[] banListOnName;
    [NonSerialized] public int[] nonRepetitionSystemArray = null;
    [NonSerialized] public int numberOfQuestions;
    [NonSerialized] public string maxLvlArcade;
    [NonSerialized] int iter = 0;
    [NonSerialized] public static BannerView bannerView;
    [NonSerialized] public static InterstitialAd interstitialAd;
    [NonSerialized] public PlayerInLeaderBoard playerInLeaderBoardClassic;
    [NonSerialized] public PlayerInLeaderBoard playerInLeaderBoardArcade;

    //main
    private string inGameBanner = "ca-app-pub-3015742885636577/3206900730";

    //test
    //private string inGameBanner = "ca-app-pub-3940256099942544/6300978111";

    //main
    public readonly string inInterstitialAd = "ca-app-pub-3015742885636577/1764158252";

    //test
    //public readonly string inInterstitialAd = "ca-app-pub-3940256099942544/1033173712";



    public void SetTogles(int nAnswers)
    {
        toggls.Clear();
        if (nAnswers == 4)
        {
            toggls.Add(toggleAnswer1);
            toggls.Add(toggleAnswer2);
            toggls.Add(toggleAnswer3);
            toggls.Add(toggleAnswer4);
            toggls[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(-270f, -400f);
            toggls[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(270f, -400f);
            toggls[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(-270f, -650f);
            toggls[3].GetComponent<RectTransform>().anchoredPosition = new Vector3(270f, -650f);
        }
        else if (nAnswers == 3)
        {
            toggls.Add(toggleAnswer1);
            toggls.Add(toggleAnswer2);
            toggls.Add(toggleAnswer3);
            toggls[0].GetComponent<RectTransform>().anchoredPosition = new Vector3(-270f, -400f);
            toggls[1].GetComponent<RectTransform>().anchoredPosition = new Vector3(270f, -400f);
            toggls[2].GetComponent<RectTransform>().anchoredPosition = new Vector3(0, -650f);
            toggleAnswer4.GetComponent<RectTransform>().anchoredPosition = new Vector3(2700f, -6500f);
        }
    }
    public void BlockQuestion(Questions a)
    {
        if (a.keys.Length == 4)
        {
            toggls.Clear();
            if (a.keys.Length == 4)
            {
                toggls.Add(toggleAnswer1);
                toggls.Add(toggleAnswer2);
                toggls.Add(toggleAnswer3);
                toggls.Add(toggleAnswer4);
            }
            else if (a.keys.Length == 3)
            {
                toggls.Add(toggleAnswer1);
                toggls.Add(toggleAnswer2);
                toggls.Add(toggleAnswer3);
            }

            toggleAnswer1.isOn = false;
            toggleAnswer2.isOn = false;
            toggleAnswer3.isOn = false;
            toggleAnswer4.isOn = false;
            for (int j = 0; j < toggls.Count; j++)
            {
                toggls[j].transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2");
            }
            if (a.numberAnswer <= 4 && a.numberAnswer >= 2)
            {
                for (int i = 0; i < toggls.Count; i++)
                {
                    if (a.keys[i] == a.numberAnswer)
                    {
                        toggls[i].transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2Red");
                    }
                }
            }
            else if (a.numberAnswer == 5)
            {
                for (int i = 0; i < toggls.Count; i++)
                {

                    toggls[i].transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2Red");
                }
            }
            for (int i = 0; i < toggls.Count; i++)
            {
                if (a.keys[i] == 1)
                {
                    toggls[i].transform.Find("Background").gameObject.GetComponent<Image>().overrideSprite = Resources.Load<Sprite>("Button2Green");
                }
            }
            toggleAnswer1.interactable = false;
            toggleAnswer2.interactable = false;
            toggleAnswer3.interactable = false;
            toggleAnswer4.interactable = false;
        }
        else if (a.keys.Length == 1)
        {
            DestroyAllComponentsInQuestionForItems();
            int cof = 0;
            if (a.item.Craft.Count <= 4)
            {
                cof = (a.item.Craft.Count - 1) * -120;
            }
            else
            {
                cof = -360;
            }
            textForButtosQuestions = new Text[a.item.Craft.Count * 2];
            imagesForBlockQuestion = new Image[a.item.Craft.Count * 2];
            for (int i = 0; i < a.yourCraft.Count; i++)
            {
                if (i < 4)
                {
                    textForButtosQuestions[i] = Instantiate(prefabPlaceForItem);
                    textForButtosQuestions[i].transform.SetParent(itemMenu.transform, false);
                    textForButtosQuestions[i].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, 80);
                    if (a.numberAnswer == 1)
                    {
                        textForButtosQuestions[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);
                    }
                    else
                    {
                        textForButtosQuestions[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f, 1f);
                    }

                    imagesForBlockQuestion[i] = Instantiate(prefabImageItemCraft);
                    imagesForBlockQuestion[i].transform.SetParent(itemMenu.transform, false);
                    imagesForBlockQuestion[i].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, 80);
                    imagesForBlockQuestion[i].sprite = Resources.Load<Sprite>($"Spells/{a.yourCraft[i].Image}");
                    if (a.yourCraft[i].Image == "") imagesForBlockQuestion[i].color = new Color(0, 0, 0, 0);
                }
            }
            if (a.yourCraft.Count >= 5)
            {
                cof = (a.yourCraft.Count - 5) * -120;
                for (int i = 0; i < a.yourCraft.Count - 4; i++)
                {
                    textForButtosQuestions[i + 4] = Instantiate(prefabPlaceForItem);
                    textForButtosQuestions[i + 4].transform.SetParent(itemMenu.transform, false);
                    textForButtosQuestions[i + 4].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, -100);
                    if (a.numberAnswer == 1)
                    {
                        textForButtosQuestions[i + 4].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);
                    }
                    else
                    {
                        textForButtosQuestions[i + 4].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0f, 0f, 1f);
                    }
                    imagesForBlockQuestion[i + 4] = Instantiate(prefabImageItemCraft);
                    imagesForBlockQuestion[i + 4].transform.SetParent(itemMenu.transform, false);
                    imagesForBlockQuestion[i + 4].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, -100);
                    imagesForBlockQuestion[i + 4].sprite = Resources.Load<Sprite>($"Spells/{a.yourCraft[i + 4].Image}");
                    if (a.yourCraft[i + 4].Image == "") imagesForBlockQuestion[i + 4].color = new Color(0, 0, 0, 0);
                }
            }
            if (a.numberAnswer == 2)
            {
                cof = 0;
                if (a.item.Craft.Count <= 4)
                {
                    cof = (a.item.Craft.Count - 1) * -120;
                }
                else
                {
                    cof = -360;
                }
                for (int i = a.item.Craft.Count; i < a.item.Craft.Count * 2; i++)
                {
                    if (i - a.item.Craft.Count < 4)
                    {
                        textForButtosQuestions[i] = Instantiate(prefabPlaceForItem);
                        textForButtosQuestions[i].transform.SetParent(itemMenu.transform, false);
                        textForButtosQuestions[i].GetComponent<RectTransform>().localPosition = new Vector3((i - a.item.Craft.Count) * 240 + cof, -360);
                        textForButtosQuestions[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);

                        imagesForBlockQuestion[i] = Instantiate(prefabImageItemCraft);
                        imagesForBlockQuestion[i].transform.SetParent(itemMenu.transform, false);
                        imagesForBlockQuestion[i].GetComponent<RectTransform>().localPosition = new Vector3((i - a.item.Craft.Count) * 240 + cof, -360);
                        imagesForBlockQuestion[i].sprite = Resources.Load<Sprite>($"Spells/{a.item.Craft[i - a.item.Craft.Count].Image}");
                        if (a.item.Craft[i - a.item.Craft.Count].Image == "") imagesForBlockQuestion[i].color = new Color(0, 0, 0, 0);
                    }
                }
                if (a.item.Craft.Count >= 5)
                {
                    cof = (a.item.Craft.Count - 5) * -120;
                    for (int i = a.item.Craft.Count; i < (a.item.Craft.Count * 2) - 4; i++)
                    {
                        textForButtosQuestions[i + 4] = Instantiate(prefabPlaceForItem);
                        textForButtosQuestions[i + 4].transform.SetParent(itemMenu.transform, false);
                        textForButtosQuestions[i + 4].GetComponent<RectTransform>().localPosition = new Vector3((i - a.item.Craft.Count) * 240 + cof, -540);
                        textForButtosQuestions[i + 4].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 1f, 0f, 1f);
                        imagesForBlockQuestion[i + 4] = Instantiate(prefabImageItemCraft);
                        imagesForBlockQuestion[i + 4].transform.SetParent(itemMenu.transform, false);
                        imagesForBlockQuestion[i + 4].GetComponent<RectTransform>().localPosition = new Vector3((i - a.item.Craft.Count) * 240 + cof, -540);
                        imagesForBlockQuestion[i + 4].sprite = Resources.Load<Sprite>($"Spells/{a.item.Craft[i - a.item.Craft.Count + 4].Image}");
                        if (a.item.Craft[i - a.item.Craft.Count + 4].Image == "") imagesForBlockQuestion[i + 4].color = new Color(0, 0, 0, 0);
                    }
                }
            }

        }
    }

    public void SetQuestion(Questions a)
    {
        a.repeated += 1;

        nonRepetitionSystemArray[a.id] = a.repeated;
        test.SetActive(true);

        if (a.question != null)
        {
            if (a.keys == null)
            {
                if (a.answers4 != "") a.keys = RandomPermutation(4);
                else a.keys = RandomPermutation(3);
            }
            imageTextQuestion.gameObject.SetActive(true);
            toggleAnswer1.gameObject.SetActive(true);
            toggleAnswer2.gameObject.SetActive(true);
            toggleAnswer3.gameObject.SetActive(true);
            toggleAnswer4.gameObject.SetActive(true);
            itemMenu.SetActive(false);
            if (startEnd && testQuestions[numberQuestion].about != "")
            {
                buttonPrompt.SetActive(true);
            }
            else
            {
                buttonPrompt.SetActive(false);
            }
            if (a.image == "" && a.sound == "" && a.question != "")
            {
                imageQuestion.gameObject.SetActive(false);
                buttonSoundQuestion.gameObject.SetActive(false);
                imageTextQuestion.gameObject.SetActive(true);
            }
            else if (a.image == "" && a.sound != "" && a.question != "")
            {
                imageQuestion.gameObject.SetActive(false);
                buttonSoundQuestion.gameObject.SetActive(true);
                imageTextQuestion.gameObject.SetActive(true);
                buttonSoundQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 400);
                buttonSoundQuestion.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>($"Sounds/{languageSounds}/Heroes/{a.sound}");
                if (buttonSoundQuestion.GetComponent<AudioSource>().clip == null)
                {
                    buttonSoundQuestion.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Spells/Help");
                }
                if (soundSetting) buttonSoundQuestion.GetComponent<AudioSource>().Play();
            }
            else if (a.image != "" && a.sound == "" && a.question != "")
            {
                imageQuestion.gameObject.SetActive(true);
                imageTextQuestion.gameObject.SetActive(true);
                buttonSoundQuestion.gameObject.SetActive(false);
                imageQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 400);
                imageQuestion.sprite = Resources.Load<Sprite>($"Spells/{a.image}");
                if (imageQuestion.sprite == null)
                {
                    imageQuestion.sprite = Resources.Load<Sprite>($"Spells/Help");
                }

                if (imageQuestion.sprite.rect.size.x == 88)
                {
                    imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(324f, 228f);
                    imageFrame.transform.localScale = new Vector3(111f, 81f, 0);
                }
                else
                {
                    imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(324f, 324f);
                    imageFrame.transform.localScale = new Vector3(110f, 110f, 0);
                }
            }
            else if (a.image != "" && a.sound != "" && a.question != "")
            {
                imageQuestion.gameObject.SetActive(true);
                buttonSoundQuestion.gameObject.SetActive(true);
                imageTextQuestion.gameObject.SetActive(true);
                imageQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(-235, 400);
                imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(323.7f, 323.7f);
                buttonSoundQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(235, 400);
                imageQuestion.sprite = Resources.Load<Sprite>($"Spells/{a.image}");
                if (imageQuestion.sprite == null)
                {
                    imageQuestion.sprite = Resources.Load<Sprite>($"Spells/Help");
                }
                buttonSoundQuestion.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>($"Sounds/{languageSounds}/Heroes/{a.sound}");
                if (buttonSoundQuestion.GetComponent<AudioSource>().clip == null)
                {
                    buttonSoundQuestion.GetComponent<Image>().sprite = Resources.Load<Sprite>($"Spells/Help");
                }
                if (soundSetting) buttonSoundQuestion.GetComponent<AudioSource>().Play();
                if (imageQuestion.sprite.rect.size.x == 88)
                {
                    imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(324f, 228f);
                    imageFrame.transform.localScale = new Vector3(111f, 81f, 0);
                }
                else
                {
                    imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(324f, 324f);
                    imageFrame.transform.localScale = new Vector3(110f, 110f, 0);
                }
            }
            else if (a.image != "" && a.sound == "" && a.question == "")
            {
                imageQuestion.gameObject.SetActive(true);
                buttonSoundQuestion.gameObject.SetActive(false);
                imageTextQuestion.gameObject.SetActive(false);
                imageQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 150);
                imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(1046, 600);
                imageQuestion.sprite = Resources.Load<Sprite>($"Spells/{a.image}");
                if (imageQuestion.sprite == null)
                {
                    imageQuestion.sprite = Resources.Load<Sprite>($"Spells/Help");
                }
            }
            question.text = a.question;
            if (a.keys[0] == 1) answer1.text = a.answers1;
            else if (a.keys[0] == 2) answer1.text = a.answers2;
            else if (a.keys[0] == 3) answer1.text = a.answers3;
            else if (a.keys[0] == 4) answer1.text = a.answers4;
            if (a.keys[1] == 1) answer2.text = a.answers1;
            else if (a.keys[1] == 2) answer2.text = a.answers2;
            else if (a.keys[1] == 3) answer2.text = a.answers3;
            else if (a.keys[1] == 4) answer2.text = a.answers4;
            if (a.keys[2] == 1) answer3.text = a.answers1;
            else if (a.keys[2] == 2) answer3.text = a.answers2;
            else if (a.keys[2] == 3) answer3.text = a.answers3;
            else if (a.keys[2] == 4) answer3.text = a.answers4;
            if (a.keys.Length == 4)
            {
                if (a.keys[3] == 1) answer4.text = a.answers1;
                else if (a.keys[3] == 2) answer4.text = a.answers2;
                else if (a.keys[3] == 3) answer4.text = a.answers3;
                else if (a.keys[3] == 4) answer4.text = a.answers4;
            }
        }
        else if (a.question == null)
        {
            itemMenu.SetActive(true);
            imageTextQuestion.gameObject.SetActive(false);
            toggleAnswer1.gameObject.SetActive(false);
            toggleAnswer2.gameObject.SetActive(false);
            toggleAnswer3.gameObject.SetActive(false);
            toggleAnswer4.gameObject.SetActive(false);
            buttonSoundQuestion.gameObject.SetActive(false);
            imageQuestion.gameObject.SetActive(true);
            imageQuestion.GetComponent<RectTransform>().anchoredPosition = new Vector3(0, 400);
            imageQuestion.GetComponent<RectTransform>().sizeDelta = new Vector2(324f, 228f);
            imageFrame.transform.localScale = new Vector3(111f, 81f, 0);
            imageQuestion.sprite = Resources.Load<Sprite>($"Spells/{a.image}");
            if (imageQuestion.sprite == null)
            {
                imageQuestion.sprite = Resources.Load<Sprite>($"Spells/Help");
            }
            DestroyAllComponentsInQuestionForItems();
            if (a.keys == null)
            {
                a.keys = new byte[1] { 1 };
                int cof = 0;
                if (a.item.Craft.Count <= 4)
                {
                    cof = (a.item.Craft.Count - 1) * -120;
                }
                else
                {
                    cof = -360;
                }
                imagesForButtosQuestionsCraft = new GameObject[a.item.Craft.Count];
                textForButtosQuestions = new Text[a.item.Craft.Count];
                for (int i = 0; i < a.item.Craft.Count; i++)
                {
                    if (i < 4)
                    {

                        textForButtosQuestions[i] = Instantiate(prefabPlaceForItem);
                        textForButtosQuestions[i].transform.SetParent(itemMenu.transform, false);
                        textForButtosQuestions[i].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, 80);
                    }

                }
                if (a.item.Craft.Count >= 5)
                {
                    cof = (a.item.Craft.Count - 5) * -120;
                    for (int i = 0; i < a.item.Craft.Count - 4; i++)
                    {
                        textForButtosQuestions[i + 4] = Instantiate(prefabPlaceForItem);
                        textForButtosQuestions[i + 4].transform.SetParent(itemMenu.transform, false);
                        textForButtosQuestions[i + 4].GetComponent<RectTransform>().localPosition = new Vector3(i * 240 + cof, -100);
                    }
                }
                Array.Clear(itemsForQuestion, 0, itemsForQuestion.Length);
                for (int i = 0; i < a.item.Craft.Count; i++)
                {
                    itemsForQuestion[i] = a.item.Craft[i];
                }
                for (int i = a.item.Craft.Count; i < a.fakeItems.Count + a.item.Craft.Count; i++)
                {
                    itemsForQuestion[i] = a.fakeItems[i - a.item.Craft.Count];
                }
                List<Item> allItemsForCraft = Items.GetItemsForCraft();
                for (int i = allItemsForCraft.Count - 1; i >= 0; i--)
                {
                    for (int j = a.item.Craft.Count - 1; j >= 0; j--)
                    {
                        if (a.item.Craft[j].Name == allItemsForCraft[i].Name)
                        {
                            allItemsForCraft.RemoveAt(i);
                            break;
                        }
                    }
                }
                for (int i = allItemsForCraft.Count - 1; i >= 0; i--)
                {
                    for (int j = a.fakeItems.Count - 1; j >= 0; j--)
                    {
                        if (a.fakeItems[j].Name == allItemsForCraft[i].Name)
                        {
                            allItemsForCraft.RemoveAt(i);
                            break;
                        }
                    }
                }
                for (int i = a.item.Craft.Count + a.fakeItems.Count; i < itemsForQuestion.Length; i++)
                {
                    int rnd = UnityEngine.Random.Range(0, allItemsForCraft.Count);
                    itemsForQuestion[i] = allItemsForCraft[rnd];
                    allItemsForCraft.RemoveAt(rnd);
                }
                System.Random rng = new System.Random();

                int n = itemsForQuestion.Length;
                while (n > 1)
                {
                    n--;
                    int k = rng.Next(n + 1);
                    Item value = itemsForQuestion[k];
                    itemsForQuestion[k] = itemsForQuestion[n];
                    itemsForQuestion[n] = value;
                }
                buttosForQuestion = new Button[itemsForQuestion.Length];
                imagesForButtosQuestions = new GameObject[itemsForQuestion.Length];
                for (int i = 0; i < itemsForQuestion.Length; i++)
                {
                    imagesForButtosQuestions[i] = Instantiate(prefabImageBackItem.gameObject);
                    imagesForButtosQuestions[i].transform.SetParent(itemMenu.transform, false);
                    imagesForButtosQuestions[i].transform.localPosition = new Vector3(-300 + (i % 4) * 200, -370 - (i / 4) * 150);
                    buttosForQuestion[i] = Instantiate(prefabButtonItem);
                    buttosForQuestion[i].transform.SetParent(itemMenu.transform, false);
                    buttosForQuestion[i].GetComponent<RectTransform>().localPosition = new Vector3(-300 + (i % 4) * 200, -370 - (i / 4) * 150);
                    buttosForQuestion[i].image.sprite = Resources.Load<Sprite>($"Spells/{itemsForQuestion[i].Image}");
                    buttosForQuestion[i].GetComponent<ButtonItem>().item = itemsForQuestion[i];
                }
            }
        }
        NextQuestion.answerTier = a.tier;
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.P))
    //    {
    //        iter += 1;
    //        ScreenCapture.CaptureScreenshot($"Screen{iter}.png");
    //    }
    //}

    void Start()
    {
        xmlData.LoadKey();
        deviceId = SystemInfo.deviceUniqueIdentifier;

        textPatch.text = patch;
        textFakePatch.text = patch;
        if (keyPurchase == xmlData.CreateMD5Hash(SystemInfo.deviceUniqueIdentifier))
        {
            ads = false;
            if (bannerView != null) bannerView.Destroy();
        }
        PurchaseManager.OnPurchaseNonConsumable += PurchaseManager_OnPurchaseNonConsumable;
        if (ads && bannerView == null)
        {
            bannerView = new BannerView(inGameBanner, AdSize.SmartBanner, AdPosition.Top);
            AdRequest request = new AdRequest.Builder().Build();
            bannerView.LoadAd(request);
        }
        Input.multiTouchEnabled = false;

        audioSource = gameObject.GetComponent<AudioSource>();

        int countQuestions = t1.Count + t2.Count + t3.Count + t4.Count + t5.Count;

        if (countQuestions % 100 >= 10 && countQuestions % 100 <= 19 || countQuestions % 10 == 0 || countQuestions % 10 >= 5 && countQuestions % 10 <= 9)
        {
            text5MainSetting.text = $"{countQuestions} вопросов в базе";
        }
        else if (countQuestions % 10 >= 2 && countQuestions % 10 <= 4)
        {
            text5MainSetting.text = $"{countQuestions} вопроса в базе";
        }
        else
        {
            text5MainSetting.text = $"{countQuestions} вопрос в базе";
        }
        stats = new byte[countQuestions];
    }

    public void SetKeyPurchase(string key)
    {
        keyPurchase = key;
    }
    public void ActiveBlackout1100(GameObject go)
    {
        gO = go;
        blackout1100.SetActive(true);
        Invoke("OffBlackout1100", 1);
    }
    public void ActiveBlackout1100()
    {
        gO = null;
        blackout1100.SetActive(true);
        Invoke("OffBlackout1100", 1);
    }
    private void OffBlackout1100()
    {
        if (gO != null) gO.SetActive(true);
        blackout1100.SetActive(false);
    }
    public void ActiveBlackout1001(GameObject go)
    {
        gO = go;
        blackout1001.SetActive(false);
        Invoke("OffBlackout1001", 1);
    }
    public void ActiveBlackout1001()
    {
        gO = null;
        blackout1001.SetActive(true);
        Invoke("OffBlackout1001", 1);
    }
    private void OffBlackout1001()
    {
        if (gO != null) gO.SetActive(false);
        blackout1001.SetActive(false);
    }
    public void SetName(Text a)
    {
        if (a.text != "") playerName = a.text;
    }

    private void PurchaseManager_OnPurchaseNonConsumable(PurchaseEventArgs args)
    {
        xmlData.SaveKey();
        ads = false;
        bannerView.Destroy();
    }

    public void AudioManager(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }

    public void LoadinInterstitialAd()
    {
        interstitialAd = new InterstitialAd(inInterstitialAd);
        AdRequest request = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(request);
    }

    byte[] RandomPermutation(int a)
    {
        if (a == 4)
        {
            byte[] array = new byte[4] { 1, 2, 3, 4 };
            int n = array.Length;
            System.Random rng = new System.Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                byte value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return array;
        }
        else if (a == 3)
        {
            byte[] array = new byte[3] { 1, 2, 3 };
            int n = array.Length;
            System.Random rng = new System.Random();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                byte value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return array;
        }
        return new byte[3] { 1, 2, 3 };
    }

    private void DestroyAllComponentsInQuestionForItems()
    {
        if (textForButtosQuestions != null)
        {
            for (int i = 0; i < textForButtosQuestions.Length; i++)
            {
                if (textForButtosQuestions[i] != null)
                {
                    Destroy(textForButtosQuestions[i].gameObject);
                }
            }
        }
        if (buttosForQuestion != null)
        {
            for (int i = 0; i < buttosForQuestion.Length; i++)
            {
                if (buttosForQuestion[i] != null)
                {
                    Destroy(buttosForQuestion[i].gameObject);
                }
            }
        }
        if (imagesForButtosQuestions != null)
        {
            for (int i = 0; i < imagesForButtosQuestions.Length; i++)
            {
                if (imagesForButtosQuestions[i] != null)
                {
                    Destroy(imagesForButtosQuestions[i].gameObject);
                }
            }
        }
        if (imagesForBlockQuestion != null)
        {
            for (int i = 0; i < imagesForBlockQuestion.Length; i++)
            {
                if (imagesForBlockQuestion[i] != null)
                {
                    Destroy(imagesForBlockQuestion[i].gameObject);
                }
            }
        }
    }
}
