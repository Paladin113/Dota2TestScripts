using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using TMPro;

public class ButtonConfirm : MonoBehaviour
{
    [SerializeField] Game game = null;
    [SerializeField] GameObject test = null;
    [SerializeField] public AudioClip audioStinger = null;
    [SerializeField] GameObject bestPlayer = null;
    [SerializeField] private GameObject triggerEndTest = null;
    [SerializeField] private Button buttonConfirm = null;
    [SerializeField] private Text textWarrning = null;
    [SerializeField] private InputField inputField = null;
    private bool resolve = false;
    private void Start()
    {
        game.loading.baseConnect.GetMmrThread();
        if (game.ban == true)
        {
            bestPlayer.SetActive(false);
            triggerEndTest.SetActive(true);
        }
        game.AudioManager(audioStinger);
        test.SetActive(false);
        game.ActiveBlackout1001();
        if (game.playerName != "") inputField.text = game.playerName;
    }

    public void ClickСonfirm()
    {
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
        game.loading.baseConnect.SendBaseThread();
        game.ActiveBlackout1100();
        Invoke("DeleyOff", 1);
        triggerEndTest.SetActive(true);
        game.xmlData.SaveStats();
        SatNameToLeaderBoardThread();
    }
    private void DeleyOff()
    {
        bestPlayer.SetActive(false);
    }
    private void FixedUpdate()
    {

        if (bestPlayer.transform.localScale.x > 1)
        {
            bestPlayer.transform.localScale = new Vector3(bestPlayer.transform.localScale.x - 0.06f, bestPlayer.transform.localScale.y - 0.06f, bestPlayer.transform.localScale.z);
        }
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
                        buttonConfirm.interactable = false;
                        resolve = false;
                    }
                }
            }
            if (resolve)
            {

                if (inputField.text.Length > 16)
                {
                    buttonConfirm.interactable = false;
                    textWarrning.text = "Ник дожен быть меньше 17 символов";
                }
                else
                {
                    buttonConfirm.interactable = true;
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
            buttonConfirm.interactable = false;
        }
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
