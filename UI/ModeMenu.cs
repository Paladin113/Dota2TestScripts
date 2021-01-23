using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ModeMenu : MonoBehaviour
{
    [SerializeField] Game game = null;
    [SerializeField] GameObject content = null;
    [SerializeField] Text textContent = null;
    [SerializeField] Button buttonClassic = null;
    [SerializeField] Button buttonArcade = null;
    [SerializeField] ParticleSystem particlebuttonClassic = null;
    [SerializeField] ParticleSystem particleButtonArcade = null;
    [SerializeField] Image imageButtonArcade = null;
    [SerializeField] Image imageButtonClassic = null;
    [NonSerialized] public string arcadeText = "Бесконечный режим с одной жизнью, каждые 15 вопросов увеличивают сложность теста. По завершению показывается ваша статистика.";

    private Color col;

    private void Start()
    {
        col = textContent.color;
    }

    private void FixedUpdate()
    {
        if (content.transform.localPosition.x > -430)
        {
            particlebuttonClassic.Play();
            particleButtonArcade.Stop();
            if (imageButtonClassic.gameObject.activeSelf == false || imageButtonClassic.gameObject.activeSelf == false)
            {
                buttonClassic.interactable = true;
                buttonArcade.interactable = false;
            }

            textContent.text = "Постепенно усложняющийся тест, состоящий из 30 вопросов. По завершению показывается ваш ММР.";
            textContent.color = new Color(1.000f, 0.997f, 0.667f, 1f - content.transform.localPosition.x / -430);
        }
        else if (content.transform.localPosition.x < 431)
        {
            particlebuttonClassic.Stop();
            particleButtonArcade.Play();
            if (imageButtonArcade.gameObject.activeSelf == false || imageButtonArcade.gameObject.activeSelf == false)
            {
                buttonClassic.interactable = false;
                buttonArcade.interactable = true;
            }
            textContent.text = arcadeText;
            if (game.classicPassed == true) textContent.color = new Color(0.373f, 0.796f, 0.737f, (content.transform.localPosition.x + 430) / -455f);
            else textContent.color = new Color(1, 1, 1, (content.transform.localPosition.x + 430) / -455f);
        }
    }
}
