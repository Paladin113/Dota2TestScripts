using UnityEngine;
using UnityEngine.UI;
using System.Runtime;
using System.Collections.Generic;

public class ButtonAcceptTest : MonoBehaviour
{
    [SerializeField] private GameObject startTest = null;
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject acceptTest = null;
    [SerializeField] private GameObject acceptTest1Light = null;
    [SerializeField] private GameObject acceptTest2Light = null;
    [SerializeField] private GameObject backgroundGrey = null;
    [SerializeField] private GameObject perehod = null;
    [SerializeField] private GameObject perehodStartElement = null;
    [SerializeField] private GameObject accept = null;
    [SerializeField] private GameObject buttonNextQuestion = null;
    [SerializeField] private GameObject timerArcade = null;
    private int time = 0;
    private bool acceptPress = false;

    public void SetAccept()
    {
        acceptPress = true;
    }

    public void MakeTest()
    {
        backgroundGrey.SetActive(false);
        perehod.SetActive(true);
        perehodStartElement.GetComponent<BlockAnimation>().active = true;
        startTest.SetActive(true);
        buttonNextQuestion.gameObject.SetActive(true);
        game.timeStartTest = System.DateTime.Now;
        if (game.gameMode == "Classic")
        {
            for (int i = 0; i < 10; i++)
            {
                game.testQuestions.Add(game.t1[0]);
                game.t1.Remove(game.t1[0]);
            }
            for (int i = 0; i < 8; i++)
            {
                game.testQuestions.Add(game.t2[0]);
                game.t2.Remove(game.t2[0]);
            }
            for (int i = 0; i < 6; i++)
            {
                game.testQuestions.Add(game.t3[0]);
                game.t3.Remove(game.t3[0]);
            }
            for (int i = 0; i < 4; i++)
            {
                game.testQuestions.Add(game.t4[0]);
                game.t4.Remove(game.t4[0]);
            }
            for (int i = 0; i < 2; i++)
            {
                game.testQuestions.Add(game.t5[0]);
                game.t5.Remove(game.t5[0]);
            }
            game.SetQuestion(game.testQuestions[0]);
            timerArcade.SetActive(false);
        }
        else if (game.gameMode == "Arcade")
        {
            string numbersQuestionsWhisArcade = "111211232234345112212322343454122223223433545222232234334455222322343345555223323433454555233234334545555";
            while (numbersQuestionsWhisArcade.Length != 0)
            {
                if (numbersQuestionsWhisArcade[0] == '1')
                {
                    game.testQuestions.Add(game.t1[0]);
                    game.t1.Remove(game.t1[0]);
                }
                else if (numbersQuestionsWhisArcade[0] == '2')
                {
                    game.testQuestions.Add(game.t2[0]);
                    game.t2.Remove(game.t2[0]);
                }
                else if (numbersQuestionsWhisArcade[0] == '3')
                {
                    game.testQuestions.Add(game.t3[0]);
                    game.t3.Remove(game.t3[0]);
                }
                else if (numbersQuestionsWhisArcade[0] == '4')
                {
                    game.testQuestions.Add(game.t4[0]);
                    game.t4.Remove(game.t4[0]);
                }
                else if (numbersQuestionsWhisArcade[0] == '5')
                {
                    game.testQuestions.Add(game.t5[0]);
                    game.t5.Remove(game.t5[0]);
                }
                numbersQuestionsWhisArcade = numbersQuestionsWhisArcade.Remove(0, 1);
            }
            game.SetQuestion(game.testQuestions[0]);
            timerArcade.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        if (accept.transform.localScale.x > 1) accept.transform.localScale = new Vector3(accept.transform.localScale.x - 0.26f, accept.transform.localScale.y - 0.26f);

        if (acceptPress && acceptTest.transform.eulerAngles.x < 88)
        {
            acceptTest1Light.SetActive(false);
            acceptTest1Light.SetActive(false);
            acceptTest.transform.Rotate(new Vector3(10, 0, 0));
            gameObject.GetComponent<Image>().color = new Color(1, 1, 1, 0);
        }
        else if (acceptPress && acceptTest.transform.eulerAngles.x > 88)
        {
            acceptTest.transform.eulerAngles = new Vector3(90, 0, 0);
            acceptTest2Light.SetActive(true);
            time++;
            if (time * 0.02 % 60 > 0.8 && time * 0.02 % 60 < 1.8)
            {
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a + 0.06f);
            }
            else if (time * 0.02 % 60 > 1.8)
            {
                MakeTest();
                accept.SetActive(false);
            }
        }
    }
}
