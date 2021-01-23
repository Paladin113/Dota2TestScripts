using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoardClassicManager : MonoBehaviour
{
    [SerializeField] private Game game = null;
    public PlayerInLB prefabPlayerInLB = null;
    public GameObject prefabImageOutline = null;
    public GameObject content = null;
    private GameObject prefabImOutline;
    private RectTransform rectTransform;
    private Vector2 savePos = new Vector2(0,0);
    public List<PlayerInLB> playersInLB = new List<PlayerInLB>();

    public void OpanLeaderBoardClassicManeger()
    {
        rectTransform = content.GetComponent<RectTransform>();
        rectTransform.offsetMin = new Vector2(0, -100 - 100 * game.classicLeaderBoards.Count);
        for (int i = 0; i < game.classicLeaderBoards.Count; i++)
        {
            if (game.deviceId == game.classicLeaderBoards[i].deviceId)
            {
                savePos = new Vector2(-4.9f, rectTransform.offsetMin.y / -2 + 47.3f - 100 * (i + 1));
            }
            CreatePlayerInLeaderBoard(i + 1, game.classicLeaderBoards[i].name, game.classicLeaderBoards[i].rating, game.classicLeaderBoards[i].time);
        }
        if (savePos.y != 0)
        {
            prefabImOutline = Instantiate(prefabImageOutline);
            prefabImOutline.transform.SetParent(content.transform, false);
            prefabImOutline.GetComponent<RectTransform>().anchoredPosition = savePos;
        }
    }

    public void CreatePlayerInLeaderBoard(int pos, string name, int rating, int time)
    {
        PlayerInLB playerInLB = Instantiate(prefabPlayerInLB);
        playersInLB.Add(playerInLB);
        playerInLB.SetPlayerInLB(pos, name, rating, time);
        playerInLB.transform.SetParent(content.transform, false);
        playerInLB.rectTransform.anchoredPosition = new Vector2(0, rectTransform.offsetMin.y / -2 + 48.3f - 100 * pos);
    }

    public void ClearPlayersInLB()
    {
        for (int i = 0; i < playersInLB.Count; i++)
        {
            Destroy(playersInLB[i].gameObject);
        }
        playersInLB.Clear();
        if (prefabImOutline != null) Destroy(prefabImOutline.gameObject);
    }
}
