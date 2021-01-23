using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleVideoInMainMenu : MonoBehaviour
{
    [SerializeField] private AudioClip audioToggleSound = null;
    [SerializeField] private GameObject menu = null;
    [SerializeField] Game game = null;
    bool flag = false;

    private void Start()
    {
        if (menu.activeSelf)
        {
            if (game.videoInGameMenu == true)
            {
                game.videoInGameMenu = true;
                gameObject.GetComponent<Toggle>().isOn = true;
                game.loading.videoMainMenu.gameObject.SetActive(true);
            }
            else
            {
                game.videoInGameMenu = false;
                gameObject.GetComponent<Toggle>().isOn = false;
                game.loading.videoMainMenu.gameObject.SetActive(false);
            }
            flag = true;
        }
    }

    public void SetVideoSetting(bool choice)
    {
        if (menu.activeSelf)
        {
            if (choice)
            {
                game.videoInGameMenu = choice;
                gameObject.GetComponent<Toggle>().isOn = true;
                game.loading.videoMainMenu.gameObject.SetActive(true);
            }
            else
            {
                game.videoInGameMenu = choice;
                gameObject.GetComponent<Toggle>().isOn = false;
                game.loading.videoMainMenu.gameObject.SetActive(false);
            }
        }        
    }

    public void СhangeVideoSetting()
    {

        if (gameObject.GetComponent<Toggle>().isOn)
        {
            SetVideoSetting(true);
        }
        else
        {
            SetVideoSetting(false);
        }
        if (flag)
        {
            game.AudioManager(audioToggleSound);
            game.xmlData.SaveSetting();
        }
    }
}
