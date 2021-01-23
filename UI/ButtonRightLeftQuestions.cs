using UnityEngine;

public class ButtonRightLeftQuestions : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject buttonLeftQuestion = null;
    [SerializeField] private GameObject buttonRightQuestion = null;
    [SerializeField] private AudioClip audioMatchReady = null;
    [SerializeField] private ButtonPrompt buttonPrompt = null;

    void Start()
    {
        if (game.numberQuestion == 29) buttonRightQuestion.SetActive(false);
        if (game.numberQuestion == 0) buttonLeftQuestion.SetActive(false);
    }

    public void ButtonLeft()
    {
        game.AudioManager(audioMatchReady);
        buttonPrompt.buttonPromptOn = false;
        game.numberQuestion -= 1;
        game.SetQuestion(game.testQuestions[game.numberQuestion]);
        if (game.numberQuestion == 0) buttonLeftQuestion.SetActive(false);
        if (game.numberQuestion != 29) buttonRightQuestion.SetActive(true);
        game.BlockQuestion(game.testQuestions[game.numberQuestion]);
        if (game.testQuestions[game.numberQuestion].answers4 != "")
        {
            game.SetTogles(4);
        }
        else
        {
            game.SetTogles(3);
        }
    }

    public void ButtonRight()
    {
        game.AudioManager(audioMatchReady);
        buttonPrompt.buttonPromptOn = false;
        game.numberQuestion += 1;
        game.SetQuestion(game.testQuestions[game.numberQuestion]);
        if (game.numberQuestion == 29) buttonRightQuestion.SetActive(false);
        if (game.numberQuestion != 0) buttonLeftQuestion.SetActive(true);
        game.BlockQuestion(game.testQuestions[game.numberQuestion]);
        if (game.testQuestions[game.numberQuestion].answers4 != "")
        {
            game.SetTogles(4);
        }
        else
        {
            game.SetTogles(3);
        }
    }
}
