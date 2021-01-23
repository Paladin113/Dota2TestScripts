using UnityEngine;

public class ButtonBackTest : MonoBehaviour
{
    [SerializeField] private GameObject mainSettings = null;
    [SerializeField] private AudioClip audioBackMainMenu = null;
    [SerializeField] private GameObject extraMenu = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private GameObject backgroundMainMenu = null;  
    [SerializeField] private GameObject test = null;
    [SerializeField] private Game game = null;

    public void BackTest()
    {
        game.AudioManager(audioBackMainMenu);
        extraMenu.SetActive(true);
        backgroundMainMenu.SetActive(false);
        blackout.SetActive(false);
        test.gameObject.SetActive(true);
        mainSettings.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackTest();
        }
    }
}
