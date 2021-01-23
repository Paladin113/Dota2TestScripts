using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class YouDied : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private NextQuestion nextQuestion = null;
    [SerializeField] public ArcadeMeneder arcadeMeneder = null;
    [SerializeField] private ButtonResurrect buttonResurrect = null;
    [SerializeField] private GameObject resurrectPanel = null;
    [SerializeField] private GameObject imageAds = null;
    [SerializeField] private GameObject imageLines = null;
    [SerializeField] private GameObject blackout1001 = null;
    [SerializeField] private GameObject blackout1100 = null;
    [SerializeField] private Text textHpBar = null;
    [SerializeField] private Text textMpBar = null;
    [SerializeField] private RectTransform mpBarInside = null;
    [SerializeField] private RectTransform hpBarInside = null;

    public double maxHp = 2315;
    public double hp = 600;
    public double MaxMp = 615;
    public double mp = 50;

    private int rnd1 = 0;
    private int rnd2 = 50;
    private int time = 0;
    private float saveSize = 0; 

    private void Start()
    {
        if (!game.ads) imageAds.SetActive(false);
        saveSize = hpBarInside.rect.width;
        Invoke("ActiveResurrectPanel", 1);
        Invoke("OffBlackout1100", 1);
        arcadeMeneder.SoundAnger();
        blackout1100.SetActive(true);
    }

    private void OffBlackout1100()
    {
        blackout1100.SetActive(false);
    }

    private void OffImageLines()
    {
        imageLines.SetActive(false);
    }

    private void ActiveResurrectPanel()
    {
        Invoke("AnActiveBlackout", 1);
        blackout1001.SetActive(true);
        resurrectPanel.SetActive(true);
    }

    private void AnActiveBlackout()
    {
        blackout1001.SetActive(false);
    }

    public void AddHP(int i)
    {
        hp += i;
    }
    public void AddMP(int i)
    {
        mp += i;
    }

    public void Died()
    {
        hp = 0;
        textHpBar.text = $"0 / {(int)maxHp}";
        textMpBar.color = new Color(0.765f, 0.204f, 0.227f, 1.000f);
        textHpBar.color = new Color(0.765f, 0.204f, 0.227f, 1.000f);
        hpBarInside.offsetMax = new Vector3(-saveSize, 0, 0);
    }

    private void FixedUpdate()
    {
        if (hp > 0)
        {
            time++;
            hp += 0.32;
            mp += 0.046;
            textHpBar.text = $"{(int)hp} / {(int)maxHp}";
            hpBarInside.offsetMax = new Vector3((float)(-saveSize + hp * 100 / maxHp * saveSize / 100), 0, 0);
            textMpBar.text = $"{(int)mp} / {(int)MaxMp}";
            mpBarInside.offsetMax = new Vector3((float)(-saveSize + mp * 100 / MaxMp * saveSize / 100), 0, 0);
           
            if (time % rnd2 == 0)
            {
                arcadeMeneder.SoundTakeDmg();
                rnd1 = UnityEngine.Random.Range(60, 80);
                rnd2 = UnityEngine.Random.Range(40, 65);
                AddHP(-rnd1);
                imageLines.SetActive(true);
                Invoke("OffImageLines", 0.7f);
                time = 0;
            }
        }
        else if (hp <= 0)
        {
            Died();
            if (mp<160)
            {

                nextQuestion.CheckBestArcade();
            }
            else
            {
                AddMP(-160);
                textMpBar.text = $"{(int)mp} / {(int)MaxMp}";
                mpBarInside.offsetMax = new Vector3((float)(-saveSize + mp * 100 / MaxMp * saveSize / 100), 0, 0);
                arcadeMeneder.SoundReincarnation();
                arcadeMeneder.SoundDeath();
                buttonResurrect.PreResurrect();               
            }
        }
    }
}
