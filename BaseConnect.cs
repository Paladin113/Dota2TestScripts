using System;
using UnityEngine;
using System.Threading;
using MySqlConnector;
using System.Linq;


public class BaseConnect : MonoBehaviour
{
    [SerializeField] Game game = null;
    private byte[] data;
    private int mmr;
    private int timeinSec;
    private int streak;
    private string extraaLife;
    private void GetStats()
    {
        String connString = "server =****; uid = daniil; pwd = ********; database = ******";

        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand mySqlCommand = conn.CreateCommand();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 0;";
        string[] strs = mySqlCommand.ExecuteScalar().ToString().Split('.');
        game.actualVersion = Int32.Parse(strs[0] + strs[1] + strs[2]);

        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 1;";
        game.bestPlayerInClassic = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 2;";
        game.bestTimeInClassic = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 3;";
        game.bestMMRPlayerInClassic = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 4;";
        game.bestPlayerInArcade = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 5;";
        game.bestStreakInArcade = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 6;";
        game.bestExtraLife = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 7;";
        game.bestTimeInArcade = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 8;";
        game.bestMMRPlayerInArcade = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 9;";
        string str = mySqlCommand.ExecuteScalar().ToString();
        game.banList = str.Split(' ');
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 10;";
        game.developerMessage = mySqlCommand.ExecuteScalar().ToString();
        mySqlCommand.CommandText = $"select version from GAME_version where main_id = 11;";
        string st = mySqlCommand.ExecuteScalar().ToString();
        game.banListOnName = st.Split(' ');
    }
    private void GetMmr()
    {
        String connString = "server =****; uid = daniil; pwd = ********; database = ******";

        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand mySqlCommand = conn.CreateCommand();

        if (game.gameMode == "Classic")
        {
            mySqlCommand.CommandText = $"select version from GAME_version where main_id = 3;";
            game.bestMMRPlayerInClassic = mySqlCommand.ExecuteScalar().ToString();
        }
        else if (game.gameMode == "Arcade")
        {
            mySqlCommand.CommandText = $"select version from GAME_version where main_id = 8;";
            game.bestMMRPlayerInArcade = mySqlCommand.ExecuteScalar().ToString();
        }
    }
    private void SendBase()
    {
        String connString = "server =****; uid = daniil; pwd = ********; database = ******";

        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand mySqlCommand = conn.CreateCommand();

        if (game.gameMode == "Classic")
        {
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.playerName}' WHERE main_id = 1;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.timeTest}' WHERE main_id = 2;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.mMRPlayer}' WHERE main_id = 3;";
            mySqlCommand.ExecuteNonQuery();
        }
        else if (game.gameMode == "Arcade")
        {
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.playerName}' WHERE main_id = 4;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.streakInArcade}' WHERE main_id = 5;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.extraLife}' WHERE main_id = 6;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.timeTest}' WHERE main_id = 7;";
            mySqlCommand.ExecuteNonQuery();
            mySqlCommand.CommandText = $"UPDATE GAME_version SET version = '{game.mMRPlayer}' WHERE main_id = 8;";
            mySqlCommand.ExecuteNonQuery();
        }
    }
    private void SendBaseArcade()
    {
        byte[] datatemp = data.Concat(new byte[1000 - data.Length]).ToArray();
        // Connection String.
        String connString = "server =****; uid = daniil; pwd = ********; database = ******";

        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand mySqlCommand = conn.CreateCommand();
        mySqlCommand.CommandText = $"INSERT INTO arcade_test VALUES({String.Join(",", datatemp)},'{DateTime.Now}','{game.deviceId}','{mmr}','{timeinSec}','{streak}','{extraaLife}','{game.playerName}','{!game.ads}')";
        mySqlCommand.ExecuteNonQuery();
    }
    private void SendBaseClassic()
    {
        byte[] datatemp = data.Concat(new byte[1000 - data.Length]).ToArray();
        // Connection String.
        String connString = "server =****; uid = daniil; pwd = ********; database = ******";

        MySqlConnection conn = new MySqlConnection(connString);
        conn.Open();
        MySqlCommand mySqlCommand = conn.CreateCommand();
        mySqlCommand.CommandText = $"INSERT INTO stats201q VALUES({String.Join(",", datatemp)},'{DateTime.Now}','{game.deviceId}','{mmr}','{timeinSec}','{game.playerName}','{!game.ads}')";
        mySqlCommand.ExecuteNonQuery();
    }
    public void SendBaseClassicThread(byte[] data1, int mmr1, int timeinSec1)
    {
        data = data1;
        mmr = mmr1;
        timeinSec = timeinSec1;
        Thread thread = new Thread(SendBaseClassic);
        thread.Start();
    }
    public void SendBaseArcadeThread(byte[] data1, int mmr1, int timeinSec1, int streak1, string extraLife1)
    {
        data = data1;
        mmr = mmr1;
        timeinSec = timeinSec1;
        streak = streak1;
        extraaLife = extraLife1;
        Thread thread = new Thread(SendBaseArcade);
        thread.Start();
    }
    public void GetStatsThread()
    {
        Thread thread = new Thread(GetStats);
        thread.Start();
    }
    public void SendBaseThread()
    {
        Thread thread = new Thread(SendBase);
        thread.Start();
    }
    public void GetMmrThread()
    {
        Thread thread = new Thread(GetMmr);
        thread.Start();
    }
}
