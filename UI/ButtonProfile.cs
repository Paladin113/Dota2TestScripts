using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class ButtonProfile : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private ButtonChangeName buttonChangeName = null;
    [SerializeField] private GameObject changeName = null;    
    [SerializeField] private GameObject profile = null;
    [SerializeField] private GameObject stats = null;
    [SerializeField] private AudioClip audioClip = null;
    [SerializeField] private Text textProfileName = null;
    [SerializeField] private Text textProfileNameInStats = null;
    [SerializeField] private Text textMaxMmrClassicValue = null;
    [SerializeField] private Text textAverageMmrClassicValue = null;
    [SerializeField] private Text textGeneralTimeClassicValue = null;
    [SerializeField] private Text textPlayedOnceClassicValue = null;
    [SerializeField] private Text textMaxMmrArcadeValue = null;
    [SerializeField] private Text textAverageMmrArcadeValue = null;
    [SerializeField] private Text textAverageRoundArcadeValue = null;
    [SerializeField] private Text textGeneralTimeArcadeValue = null;
    [SerializeField] private Text textPlayedOnceArcadeValue = null;


    public void ClickProfile()
    {
        game.xmlData.SaveSetting();
        if (game.playerName != "")
        {
            textProfileName.text = game.playerName;
            textProfileNameInStats.text = game.playerName;
            if (Int32.Parse(game.statsPlayedOnceClassic) != 0)
            {
                textMaxMmrClassicValue.text = $"{Int32.Parse(game.statsMaxMmrClassic)} ММР";
                textAverageMmrClassicValue.text = $"{Int32.Parse(game.statsAverageMmrClassic) / Int32.Parse(game.statsPlayedOnceClassic)} ММР";
                if (Int32.Parse(game.statsGeneralTimeClassic) < 3600) textGeneralTimeClassicValue.text = $"{Int32.Parse(game.statsGeneralTimeClassic) / 60} М. {Int32.Parse(game.statsGeneralTimeClassic) % 60} С.";
                else textGeneralTimeClassicValue.text = $"{Int32.Parse(game.statsGeneralTimeClassic) / 3600} Ч. {Int32.Parse(game.statsGeneralTimeClassic) / 60} М.";

                if (Int32.Parse(game.statsPlayedOnceClassic) % 100 >= 10 && Int32.Parse(game.statsPlayedOnceClassic) % 100 <= 19 || Int32.Parse(game.statsPlayedOnceClassic) % 10 == 0 || Int32.Parse(game.statsPlayedOnceClassic) % 10 >= 5 && Int32.Parse(game.statsPlayedOnceClassic) % 10 <= 9)
                {
                    textPlayedOnceClassicValue.text = $"{Int32.Parse(game.statsPlayedOnceClassic)} раз";
                }
                else if (Int32.Parse(game.statsPlayedOnceClassic) % 10 >= 2 && Int32.Parse(game.statsPlayedOnceClassic) % 10 <= 4)
                {
                    textPlayedOnceClassicValue.text = $"{Int32.Parse(game.statsPlayedOnceClassic)} раза";
                }
                else
                {
                    textPlayedOnceClassicValue.text = $"{Int32.Parse(game.statsPlayedOnceClassic)} раз";
                }
            }

            if (Int32.Parse(game.statsPlayedOnceArcade) != 0)
            {
                textMaxMmrArcadeValue.text = $"{Int32.Parse(game.statsMaxMmrArcade)} ММР";
                textAverageMmrArcadeValue.text = $"{Int32.Parse(game.statsAverageMmrArcade) / Int32.Parse(game.statsPlayedOnceArcade)} ММР";

                textAverageRoundArcadeValue.text = $"{((Int32.Parse(game.statsAverageRoundArcade) / (Int32.Parse(game.statsPlayedOnceArcade)) - 1) / 15) + 1} К. {((Int32.Parse(game.statsAverageRoundArcade) / (Int32.Parse(game.statsPlayedOnceArcade)) - 1) % 15) + 1} В.";

                if (Int32.Parse(game.statsGeneralTimeArcade) < 3600) textGeneralTimeArcadeValue.text = $"{Int32.Parse(game.statsGeneralTimeArcade) / 60} М. {Int32.Parse(game.statsGeneralTimeArcade) % 60} С.";
                else textGeneralTimeArcadeValue.text = $"{Int32.Parse(game.statsGeneralTimeArcade) / 3600} Ч. {Int32.Parse(game.statsGeneralTimeArcade) / 60} М.";

                if (Int32.Parse(game.statsPlayedOnceArcade) % 100 >= 10 && Int32.Parse(game.statsPlayedOnceArcade) % 100 <= 19 || Int32.Parse(game.statsPlayedOnceArcade) % 10 == 0 || Int32.Parse(game.statsPlayedOnceArcade) % 10 >= 5 && Int32.Parse(game.statsPlayedOnceArcade) % 10 <= 9)
                {
                    textPlayedOnceArcadeValue.text = $"{Int32.Parse(game.statsPlayedOnceArcade)} раз";
                }
                else if (Int32.Parse(game.statsPlayedOnceArcade) % 10 >= 2 && Int32.Parse(game.statsPlayedOnceArcade) % 10 <= 4)
                {
                    textPlayedOnceArcadeValue.text = $"{Int32.Parse(game.statsPlayedOnceArcade)} раза";
                }
                else
                {
                    textPlayedOnceArcadeValue.text = $"{Int32.Parse(game.statsPlayedOnceArcade)} раз";
                }
            }
            if (buttonChangeName.mode == "OfProfile")
            {
                profile.SetActive(true);
            }
            else if (buttonChangeName.mode == "OfStats")
            {
                changeName.SetActive(false);
                stats.SetActive(true);
            }
            else if (buttonChangeName.mode == "OfButtonStats")
            {
                profile.SetActive(false);
                stats.SetActive(true);
            }            
        }
        else
        {
            if (buttonChangeName.mode == "OfButtonStats")
            {
                profile.SetActive(false);
                changeName.SetActive(true);
            }           
        }
        game.AudioManager(audioClip);
    }
}
