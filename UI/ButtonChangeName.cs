using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class ButtonChangeName : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject stats = null;
    [SerializeField] private GameObject profile = null;
    [SerializeField] private GameObject changeName = null;
    [SerializeField] private Text textWarrning = null;
    [SerializeField] private InputField inputField = null;
    [SerializeField] private Button buttonChangeName = null;
    [SerializeField] private Button buttonBackProfile = null;
    [SerializeField] private Button buttonBackStats = null;
    [SerializeField] private Text textAboveInput = null;
    public string mode = "";
    private bool resolve = false;

    public class SortByName : IComparer<PlayerInLeaderBoard>
    {
        public int Compare(PlayerInLeaderBoard x, PlayerInLeaderBoard y)
        {
            if (x.rating != y.rating)
            {
                if (x.rating < y.rating) return 1;
                else return -1;
            }
            else if (x.time != y.time)
            {
                if (x.time > y.time) return 1;
                else return -1;
            }
            else return 0;
        }
    }

    public void ChangeComponents()
    {
        if (game.playerName != "")
        {
            textAboveInput.text = "Тут вы можете изменить свой ник.";
            inputField.text = game.playerName;
        }
        else
        {
            textAboveInput.text = "Укажите ник чтобы.";
        }
        if(mode == "OfProfile" || mode == "OfButtonStats")
        {
            profile.SetActive(false);
            buttonBackProfile.gameObject.SetActive(true);
            buttonBackStats.gameObject.SetActive(false);
        }
        else if (mode == "OfStats")
        {
            stats.SetActive(false);
            buttonBackProfile.gameObject.SetActive(false);
            buttonBackStats.gameObject.SetActive(true);
        }
    }
    public void ClickChangeName()
    {
        if (game.playerName == "")
        {
            if (game.playerInLeaderBoardClassic != null) game.classicLeaderBoards.Add(game.playerInLeaderBoardClassic);
            if (game.playerInLeaderBoardArcade != null) game.arcadeLeaderBoards.Add(game.playerInLeaderBoardArcade);
        }
        SortByName comp = new SortByName();
        game.classicLeaderBoards.Sort(comp);
        game.arcadeLeaderBoards.Sort(comp);

        if (game.banOnName == false) game.playerName = inputField.text;
        else
        {
            int j = game.playerName.Length;
            game.playerName = "";
            for (int i = 0; i < j; i++)
            {
                if (i < 8) game.playerName += "*";
            }
        }
        game.xmlData.SaveStats();
        game.loading.SetMedal();
        if (game.actualVersion != 0) SatNameToLeaderBoardThread();
        for (int i = 0; i < game.classicLeaderBoards.Count; i++)
        {
            if (game.classicLeaderBoards[i].deviceId == game.deviceId) game.classicLeaderBoards[i].name = game.playerName;
        }
        for (int i = 0; i < game.arcadeLeaderBoards.Count; i++)
        {
            if (game.arcadeLeaderBoards[i].deviceId == game.deviceId) game.arcadeLeaderBoards[i].name = game.playerName;
        }
        changeName.SetActive(false);
    }

    private void FixedUpdate()
    {
        if (inputField.text.Length > 0)
        {
            resolve = true;
            if (inputField.text.Length != 0)
            {
                for (int i = 0; i < inputField.text.Length; i++)
                {
                    char c = inputField.text[i];
                    if ((c >= 'а') && (c <= 'я') || (c >= 'a') && (c <= 'z') || (c >= 'А') && (c <= 'Я') || (c >= 'A') && (c <= 'Z') || (c >= '0') && (c <= '9'))
                    {

                    }
                    else
                    {
                        buttonChangeName.interactable = false;
                        resolve = false;
                    }
                }
            }
            if (resolve)
            {

                if (inputField.text.Length > 16)
                {
                    buttonChangeName.interactable = false;
                    textWarrning.text = "Ник дожен быть меньше 17 символов";
                }
                else
                {
                    buttonChangeName.interactable = true;
                    textWarrning.text = "";
                }
            }
            else
            {
                textWarrning.text = "В нике может содержвать только буквы Рус., Анг., алфавита и цифры без пробела";
            }
        }
        else
        {
            textWarrning.text = "";
            buttonChangeName.interactable = false;
        }
    }

    public void SetMode(string str)
    {
        mode = str;
    }

    private void SatNameToLeaderBoard()
    {
        LeaderBoardManager.SatNamePlayerToLeaderBoard(game.deviceId, game.playerName);
    }


    public void SatNameToLeaderBoardThread()
    {
        Thread thread = new Thread(SatNameToLeaderBoard);
        thread.Start();
    }
}
