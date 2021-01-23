using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartNewPlayer2 : MonoBehaviour
{
    [SerializeField] private Text startNewPlayer2Text = null;
    [SerializeField] private GameObject triggerWantAssessment = null;
    [SerializeField] AudioClip audioClip = null;
    [SerializeField] Game game = null;
    void Start()
    {
        game.AudioManager(audioClip);
        BaseQuestions baseQuestions = new BaseQuestions();
        List<Questions> questions = baseQuestions.BaseActive();

        int countQuestions = questions.Count;

        if (countQuestions % 100 >= 10 && countQuestions % 100 <= 19 || countQuestions % 10 == 0 || countQuestions % 10 >= 5 && countQuestions % 10 <= 9)
        {
            startNewPlayer2Text.text = $"База содержит в себе {countQuestions} вопросов.";
        }
        else if (countQuestions % 10 >= 2 && countQuestions % 10 <= 4)
        {
            startNewPlayer2Text.text = $"База содержит в себе {countQuestions} вопроса.";
        }
        else
        {
            startNewPlayer2Text.text = $"База содержит в себе {countQuestions} вопрос.";
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            game.newPlayer = false;
            triggerWantAssessment.SetActive(true);
            game.xmlData.SaveSetting();
            gameObject.SetActive(false);
        }
    }
}
