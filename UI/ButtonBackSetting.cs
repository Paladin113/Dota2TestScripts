using UnityEngine;

public class ButtonBackSetting : MonoBehaviour
{
    [SerializeField] private GameObject authors = null;
    [SerializeField] private AudioClip audioBackSetting = null;
    [SerializeField] private GameObject about = null;
    [SerializeField] private ButtonMail buttonMail = null;
    [SerializeField] private Game game = null;

    public void BackMainMenu()
    {
        game.AudioManager(audioBackSetting);
        buttonMail.flag = false;
        buttonMail.imageBuffer.color = new Color(1, 1, 1, 0);
        buttonMail.textBuffer.color = new Color(1, 1, 1, 0);
        buttonMail.time = 0;
        authors.SetActive(false);
        about.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackMainMenu();
        }
    }
}
