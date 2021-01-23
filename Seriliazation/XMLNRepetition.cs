using System;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using UnityEngine.Audio;

public class XMLNRepetition : MonoBehaviour
{
    [SerializeField] public Game game = null;
    public void SaveNonRepetitionSystem()
    {
        string _path = Path.Combine(Application.persistentDataPath, "NonRepetitionSystem.tpp");
        XmlDocument xmlDoc = new XmlDocument();
        XmlNode rootNode = xmlDoc.CreateElement("Dota2Test");
        xmlDoc.AppendChild(rootNode);
        XmlElement supElement = xmlDoc.CreateElement("NonRepetitionSystem");
        rootNode.AppendChild(supElement);

        string str = "";
        for (int i = 0; i < game.nonRepetitionSystemArray.Length; i++)
        {
            str += game.nonRepetitionSystemArray[i].ToString() + " ";
        }

        XmlElement element = xmlDoc.CreateElement("NonRepetitionSystemArray");
        element.InnerText = str;
        supElement.AppendChild(element);

        xmlDoc.Save(_path);
    }

    public int[] LoadNonRepetitionSystem()
    {
        string _path = Path.Combine(Application.persistentDataPath, "NonRepetitionSystem.tpp");
        int[] nonRepetitionArray = new int[game.numberOfQuestions];
        if (File.Exists(_path))
        {
            string str = "";
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(_path);
            XmlElement xRoot = xmlDoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.LocalName == "NonRepetitionSystem")
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "NonRepetitionSystemArray")
                        {
                            str = childnode.InnerText;
                        }
                    }
                }
            }
            string[] str2 = str.Split(' ');
            for (int i = 0; i < str2.Length-1; i++)
            {
                nonRepetitionArray[i] = Int32.Parse(str2[i]);
            }
        }
        return nonRepetitionArray;
    }
}
