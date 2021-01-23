using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonItem : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private RectTransform rectTransform = null;
    [SerializeField] public Item item = null;
    [SerializeField] public AudioSource audioSource = null;
    private bool onCraft = false;

    public void ClickOnButton()
    {
        audioSource.Play();
        if (onCraft == false)
        {
            for (int i = 0; i < game.imagesForButtosQuestionsCraft.Length; i++)
            {
                if (game.imagesForButtosQuestionsCraft[i] == null)
                {
                    game.imagesForButtosQuestionsCraft[i] = gameObject;
                    for (int j = 0; j < game.itemsForQuestion.Length; j++)
                    {
                        if(game.itemsForQuestion[j] != null)
                        {
                            if (game.itemsForQuestion[j].Name == item.Name)
                            {
                                game.itemsForQuestion[j] = null;
                                break;
                            }
                        }                       
                    }
                    rectTransform.sizeDelta = new Vector2(190f, 135f);
                    rectTransform.anchoredPosition = game.textForButtosQuestions[i].rectTransform.anchoredPosition;
                    onCraft = true;
                    break;
                }
            }        
        }
        else if (onCraft == true)
        {
            for (int i = 0; i < game.itemsForQuestion.Length; i++)
            {
                if(game.itemsForQuestion[i] == null)
                {
                    for (int j = 0; j < game.imagesForButtosQuestionsCraft.Length; j++)
                    {
                        if(game.imagesForButtosQuestionsCraft[j] != null)
                        {
                            if (game.imagesForButtosQuestionsCraft[j].GetComponent<ButtonItem>().item.Name == item.Name)
                            {
                                game.imagesForButtosQuestionsCraft[j] = null;
                                break;
                            }
                        }                      
                    }                   
                    game.itemsForQuestion[i] = item;
                    rectTransform.sizeDelta = new Vector2(160f, 113f);
                    rectTransform.anchoredPosition = game.imagesForButtosQuestions[i].transform.localPosition;
                    onCraft = false;
                    break;
                }
            }        
        }
    }

    void Start()
    {
        game = FindObjectOfType<Game>();
    }
}
