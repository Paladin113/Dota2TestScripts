using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Net;
using System.IO;
using Newtonsoft.Json;

[Serializable]
public class PlayerInLeaderBoard
{
    public string name;
    public string deviceId;
    public int rating;
    public int time;
}
class LeaderBoardManager
{
    public static PlayerInLeaderBoard[] GetClassicLeaderBoard()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://****/spring-mvc-app1/api/leaderboard/getClassicLeaderBoard");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream()); 
        string jsonResponse = "{\"Items\":" + reader.ReadToEnd() + "}";
        PlayerInLeaderBoard[] info = JsonHelper.FromJson<PlayerInLeaderBoard>(jsonResponse);
        Debug.Log("Загружена таблица Classic");
        return info;
    }
    public static PlayerInLeaderBoard[] GetArcadeLeaderBoard()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://****/spring-mvc-app1/api/leaderboard/getArcadeLeaderBoard");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        string jsonResponse = "{\"Items\":" + reader.ReadToEnd() + "}";
        Debug.Log("Загружена таблица Arcade");
        PlayerInLeaderBoard[] info = JsonHelper.FromJson<PlayerInLeaderBoard>(jsonResponse);
        return info;
    }
    public static void AddPlayerClassicToLeaderBoard(string name, string deviceId, int rating, int time)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/addClassicLeaderBoard/{name}&{deviceId}&{rating}&{time}");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Добавлен игрок Classic");
    }
    public static void AddPlayerArcadeToLeaderBoard(string name, string deviceId, int rating, int time)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/addArcadeLeaderBoard/{name}&{deviceId}&{rating}&{time}");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Добавлен игрок Arcade");
    }
    public static void SatNamePlayerToLeaderBoard(string deviceId, string name)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/setName/{deviceId}&{name}");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Изменен ник игрока");
    }

    public static void RemovePlayerClassicToLeaderBoard(string deviceId)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/removePlayerClassic/{deviceId}");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Игрок удалён из таблицы Classic");
    }
    public static void RemovePlayerArcadeToLeaderBoard(string deviceId)
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/removePlayerArcade/{deviceId}");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Игрок удалён из таблицы Arcade");
    }
    public static void ClearClassicLeaderBoard()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/clearClassicLeaderBoard");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Обнулена таблица Classic");
    }
    public static void ClearArcadeLeaderBoard()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://****/spring-mvc-app1/****/clearArcadeLeaderBoard");
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Debug.Log("Обнулена таблица Arcade");
    }
}
