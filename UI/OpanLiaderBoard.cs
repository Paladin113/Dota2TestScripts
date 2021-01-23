using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class OpanLiaderBoard : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private LeaderBoardClassicManager liaderBoardClassic = null;
    [SerializeField] private Text textMonthClassic = null;
    [SerializeField] private LeaderBoardArcadeManager liaderBoardArcade = null;
    [SerializeField] private Text textMonthArcade = null;
    [SerializeField] private GameObject profile = null;
    [SerializeField] private AudioClip audioClip = null;

    public void ClickOnOpanLiaderBoard(string str)
    {
        if (game.playerName == "")
        {
            textMonthClassic.text = "Чтобы попасть в таблицу рейтинга, нужно указать свой никнейм в настройках";
            textMonthArcade.text = "Чтобы попасть в таблицу рейтинга, нужно указать свой никнейм в настройках";
            for (int i = 0; i < game.classicLeaderBoards.Count; i++)
            {
                if (game.deviceId == game.classicLeaderBoards[i].deviceId)
                {

                    game.playerInLeaderBoardClassic = game.classicLeaderBoards[i];
                    game.classicLeaderBoards.Remove(game.classicLeaderBoards[i]);
                }
            }
            for (int i = 0; i < game.arcadeLeaderBoards.Count; i++)
            {
                if (game.deviceId == game.arcadeLeaderBoards[i].deviceId)
                {
                    game.playerInLeaderBoardArcade = game.arcadeLeaderBoards[i];
                    game.arcadeLeaderBoards.Remove(game.arcadeLeaderBoards[i]);
                }
            }
        }
        else
        {
            textMonthClassic.text = "Январь";
            textMonthArcade.text = "Январь";
        }

        if (str == "Classic")
        {
            game.AudioManager(audioClip);
            liaderBoardClassic.gameObject.SetActive(true);
            profile.SetActive(false);
            liaderBoardClassic.OpanLeaderBoardClassicManeger();

        }
        else if (str == "Arcade")
        {
            game.AudioManager(audioClip);
            liaderBoardArcade.gameObject.SetActive(true);
            profile.SetActive(false);
            liaderBoardArcade.OpanLeaderBoardArcadeManeger();
        }
    }
}
