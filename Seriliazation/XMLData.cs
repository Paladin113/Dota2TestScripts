using System;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine.Audio;


public class XMLData : MonoBehaviour
{
    [SerializeField] Game game = null;
    public string CreateMD5Hash(string input)
    {
        MD5 md5 = System.Security.Cryptography.MD5.Create();
        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input + "salt123");
        byte[] hashBytes = md5.ComputeHash(inputBytes);
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(hashBytes[i].ToString("X2"));
        }
        return sb.ToString();
    }
    public void LoadStats()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Stats.tpp");
        if (File.Exists(_path))
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists(_path))
            {
                xmlDoc.Load(_path);
                XmlElement xRoot = xmlDoc.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.LocalName == "Stats")
                    {
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "PlayerName")
                            {
                                game.playerName = childnode.InnerText;
                            }
                            else if (childnode.Name == "MaxMmrClassic")
                            {
                                game.statsMaxMmrClassic = childnode.InnerText;
                            }
                            else if (childnode.Name == "AverageMmrClassic")
                            {
                                game.statsAverageMmrClassic = childnode.InnerText;
                            }
                            else if (childnode.Name == "GeneralTimeClassic")
                            {
                                game.statsGeneralTimeClassic = childnode.InnerText;
                            }
                            else if (childnode.Name == "PlayedOnceClassic")
                            {
                                game.statsPlayedOnceClassic = childnode.InnerText;
                            }
                            else if (childnode.Name == "MaxMmrArcade")
                            {
                                game.statsMaxMmrArcade = childnode.InnerText;
                            }
                            else if (childnode.Name == "AverageMmrArcade")
                            {
                                game.statsAverageMmrArcade = childnode.InnerText;
                            }
                            else if (childnode.Name == "AverageRoundArcade")
                            {
                                game.statsAverageRoundArcade = childnode.InnerText;
                            }
                            else if (childnode.Name == "GeneralTimeArcade")
                            {
                                game.statsGeneralTimeArcade = childnode.InnerText;
                            }
                            else if (childnode.Name == "PlayedOnceArcade")
                            {
                                game.statsPlayedOnceArcade = childnode.InnerText;
                            }
                        }
                    }
                }
            }
        }
    }

    public void SaveStats()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Stats.tpp");
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("Dota2Test");
        xmlDoc.AppendChild(rootNode);
        XmlElement supElement = xmlDoc.CreateElement("Stats");
        rootNode.AppendChild(supElement);

        XmlElement element = xmlDoc.CreateElement("PlayerName");
        element.InnerText = game.playerName.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("MaxMmrClassic");
        element.InnerText = game.statsMaxMmrClassic.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("AverageMmrClassic");
        element.InnerText = game.statsAverageMmrClassic.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("GeneralTimeClassic");
        element.InnerText = game.statsGeneralTimeClassic.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("PlayedOnceClassic");
        element.InnerText = game.statsPlayedOnceClassic.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("MaxMmrArcade");
        element.InnerText = game.statsMaxMmrArcade.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("AverageMmrArcade");
        element.InnerText = game.statsAverageMmrArcade.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("AverageRoundArcade");
        element.InnerText = game.statsAverageRoundArcade.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("GeneralTimeArcade");
        element.InnerText = game.statsGeneralTimeArcade.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("PlayedOnceArcade");
        element.InnerText = game.statsPlayedOnceArcade.ToString();
        supElement.AppendChild(element);

        xmlDoc.Save(_path);
    }
    public void SaveKey()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Key.tpp");
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("Dota2Test");
        xmlDoc.AppendChild(rootNode);
        XmlElement supElement = xmlDoc.CreateElement("Keys");
        rootNode.AppendChild(supElement);
        XmlElement element = xmlDoc.CreateElement("Purchase");
        element.InnerText = CreateMD5Hash(SystemInfo.deviceUniqueIdentifier);
        supElement.AppendChild(element);
        xmlDoc.Save(_path);
    }



    public void SaveSetting()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Settings.tpp");
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("Dota2Test");
        xmlDoc.AppendChild(rootNode);
        XmlElement supElement = xmlDoc.CreateElement("Settings");
        rootNode.AppendChild(supElement);

        XmlElement element = xmlDoc.CreateElement("SoundSetting");
        element.InnerText = game.soundSetting.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("MusicSetting");
        element.InnerText = game.musicSetting.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("Touch");
        element.InnerText = game.touch.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("NewPlayer");
        element.InnerText = game.newPlayer.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("Patch");
        element.InnerText = game.versionGame.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("ClassicPassed");
        element.InnerText = game.classicPassed.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("PromptInModeMenu");
        element.InnerText = game.promptInModeMenu.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("VideoInMainMenu");
        element.InnerText = game.videoInGameMenu.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("LanguageMenu");
        element.InnerText = game.languageMenu.ToString();
        supElement.AppendChild(element);

        element = xmlDoc.CreateElement("LanguageSounds");
        element.InnerText = game.languageSounds.ToString();
        supElement.AppendChild(element);

        xmlDoc.Save(_path);
    }

    public List<string> LoadSetting()
    {

        string _path = Path.Combine(Application.persistentDataPath, "Settings.tpp");
        List<string> settingString = new List<string>();
        if (File.Exists(_path))
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (File.Exists(_path))
            {
                xmlDoc.Load(_path);
                XmlElement xRoot = xmlDoc.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    if (xnode.LocalName == "Settings")
                    {
                        foreach (XmlNode childnode in xnode.ChildNodes)
                        {
                            if (childnode.Name == "SoundSetting")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "MusicSetting")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "Touch")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "NewPlayer")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "Patch")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "ClassicPassed")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "PromptInModeMenu")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "VideoInMainMenu")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "LanguageMenu")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                            else if (childnode.Name == "LanguageSounds")
                            {
                                settingString.Add(childnode.InnerText);
                            }
                        }
                    }
                }
            }
        }
        return settingString;
    }

    public void LoadKey()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Key.tpp");
        if (File.Exists(_path))
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_path);
            XmlElement xRoot = xmlDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.LocalName == "Keys")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "Purchase")
                        {
                            game.SetKeyPurchase(childnode.InnerText);
                        }
                    }
                }
            }
        }
    }
    public void DeliteKey()
    {
        string _path = Path.Combine(Application.persistentDataPath, "Key.tpp");
        File.Delete(_path);
    }
}
