using UnityEngine;
using UnityEngine.UI;

public class ButtonSetting : MonoBehaviour
{
    [SerializeField] private GameObject extraMenu = null;
    [SerializeField] private GameObject mainMenu = null;
    [SerializeField] private GameObject profile = null;
    [SerializeField] private AudioClip audioAboutTest = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private Button buttonNoAds = null;
    [SerializeField] private Button buttonStats = null;
    [SerializeField] private Button buttonBackMainMenu = null;
    [SerializeField] private GameObject textPatch = null;
    [SerializeField] private Game game = null;

    public void SettingMain()
    {
        game.AudioManager(audioAboutTest);
        extraMenu.SetActive(true);
        buttonBackMainMenu.gameObject.SetActive(true);
        profile.SetActive(true);
        mainMenu.SetActive(false);
        blackout.gameObject.SetActive(true);
        textPatch.SetActive(false);
        if (game.ads) buttonStats.gameObject.SetActive(false);
        else buttonNoAds.gameObject.SetActive(false);
    }
}
