using System.Net;
using System.Net.Sockets;
using System.Text;
using System;
using UnityEngine;
using System.Threading;
using MySqlConnector;
using System.Linq;

public class StatsSender
{
    //private byte[] data;
    //private int mmr;
    //private int timeinSec;
    //private int streak;
    //private string extraLife;

    //public void DoSendClassic()
    //{
    //    byte[] datatemp = data.Concat(new byte[1000 - data.Length]).ToArray();
    //    // Connection String.
    //    String connString = "server =194.32.248.19; uid = daniil; pwd = qwer; database = statsDB";

    //    MySqlConnection conn = new MySqlConnection(connString);
    //    conn.Open();
    //    MySqlCommand mySqlCommand = conn.CreateCommand();
    //    mySqlCommand.CommandText = $"INSERT INTO stats201q VALUES({String.Join(",", datatemp)},'{DateTime.Now}','{Game.deviceId}')";
    //    mySqlCommand.ExecuteNonQuery();
    //}
    //public void SendStatsClassic(byte[] data1)
    //{
    //    data = data1;
    //    Thread thread = new Thread(DoSendClassic);
    //    thread.Start();
    //}

    //public void DoSendArcade()
    //{
    //    byte[] datatemp = data.Concat(new byte[1000 - data.Length]).ToArray();
    //    // Connection String.
    //    String connString = "server =194.32.248.19; uid = daniil; pwd = qwer; database = statsDB";

    //    MySqlConnection conn = new MySqlConnection(connString);
    //    conn.Open();
    //    MySqlCommand mySqlCommand = conn.CreateCommand();
    //    mySqlCommand.CommandText = $"INSERT INTO arcade_test VALUES({String.Join(",", datatemp)},'{DateTime.Now}','{Game.deviceId}','{mmr}','{timeinSec}','{streak}','{extraLife}','{game.playerName}')";
    //    mySqlCommand.ExecuteNonQuery();
    //}
    //public void SendStatsArcade(byte[] data1, int mmr1, int timeinSec1, int streak1, string extraLife1)
    //{
    //    data = data1;
    //    mmr = mmr1;
    //    timeinSec = timeinSec1;
    //    streak = streak1;
    //    extraLife = extraLife1;
    //    Thread thread = new Thread(DoSendArcade);
    //    thread.Start();
    //}
}
