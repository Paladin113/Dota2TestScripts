using UnityEngine;
using UnityEngine.UI;

public class ButtonNumberQuestion : MonoBehaviour
{
    [SerializeField] private byte number = 0;
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject end = null;
    [SerializeField] private StartTest startTest = null;
    [SerializeField] private GameObject buttonLeftQuestion = null;
    [SerializeField] private GameObject buttonRightQuestion = null;
    [SerializeField] private AudioClip audioNumberQuestion = null;

    private void Start()
    {
        if (game.testQuestions[number].numberAnswer == 1)
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("ButtonGreen");
        }
        else if (game.testQuestions[number].numberAnswer != 1)
        {
            gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("ButtonRed");
        }
        gameObject.transform.Find("Text").gameObject.GetComponent<Text>().text = (number + 1).ToString();
        gameObject.transform.Find("Text").gameObject.GetComponent<Text>().fontSize = 70;
        gameObject.transform.Find("Text").gameObject.GetComponent<Text>().color = new Color(0.9f, 0.9f, 0.9f, 1);
    }

    public void SelectQuestion()
    {
        game.AudioManager(audioNumberQuestion);

        if (number != 0 && number != 29)
        {
            buttonLeftQuestion.SetActive(true);
            buttonRightQuestion.SetActive(true);
        }
        else if (number == 0)
        {
            buttonLeftQuestion.SetActive(false);
            buttonRightQuestion.SetActive(true);
        }
        else if (number == 29)
        {
            buttonRightQuestion.SetActive(false);
            buttonLeftQuestion.SetActive(true);
        }
        game.numberQuestion = number;
        game.SetQuestion(game.testQuestions[number]);
        game.BlockQuestion(game.testQuestions[game.numberQuestion]);
        if (game.testQuestions[game.numberQuestion].answers4 != "")
        {
            game.SetTogles(4);
        }
        else
        {
            game.SetTogles(3);
        }
        startTest.ActiveRightLeftButtons();
        startTest.StartAllTest();
        end.SetActive(false);
    }
}
