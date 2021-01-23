using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class DropdownLanguageSounds : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private Dropdown dropdown = null;
    [SerializeField] private AudioSource audioSource = null;
    private void Start()
    {
        var listAvailableStrings = dropdown.options.Select(option => option.text).ToList();
        if (game.languageSounds == "RU")
        {
            dropdown.value = listAvailableStrings.IndexOf("Русский");
        }
        else if (game.languageSounds == "EN")
        {
            dropdown.value = listAvailableStrings.IndexOf("English");
        }
        audioSource.enabled = true;
    }

    public void ChangeLanguageSounds()
    {
        if (dropdown.captionText.text == "Русский")
        {
            game.languageSounds = "RU";          
        } 
        else if (dropdown.captionText.text == "English")
        {
            game.languageSounds = "EN";
        }
        game.xmlData.SaveSetting();
    }
}
