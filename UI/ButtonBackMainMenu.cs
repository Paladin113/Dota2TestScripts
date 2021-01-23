using UnityEngine;

public class ButtonBackMainMenu : MonoBehaviour
{
    [SerializeField] private GameObject extraMenu = null;
    [SerializeField] private GameObject mainSettings = null;
    [SerializeField] private AudioClip audioBackMainMenu = null;
    [SerializeField] private GameObject mainMenu = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private GameObject textPatch = null;
    [SerializeField] private Game game = null;

    public void BackMainMenu()
    {
        game.AudioManager(audioBackMainMenu);
        extraMenu.SetActive(true);
        blackout.SetActive(false);
        mainMenu.SetActive(true);
        mainSettings.SetActive(false);
        textPatch.SetActive(true);
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackMainMenu();
        }
    }
}
