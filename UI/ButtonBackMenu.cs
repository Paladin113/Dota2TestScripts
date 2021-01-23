using UnityEngine;

public class ButtonBackMenu : MonoBehaviour
{
    [SerializeField] private GameObject end = null;
    [SerializeField] private GameObject test = null;
    [SerializeField] private AudioClip audioNextQuestion = null;
    [SerializeField] private ButtonPrompt buttonPrompt = null;
    [SerializeField] private Game game = null;

    public void BackMenu()
    {
        game.AudioManager(audioNextQuestion);
        buttonPrompt.buttonPromptOn = false;
        test.SetActive(false);
        end.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            BackMenu();
        }
    }
}
