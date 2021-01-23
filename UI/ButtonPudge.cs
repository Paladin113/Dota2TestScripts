using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ButtonPudge : MonoBehaviour
{
    [SerializeField] Game game = null;
    private readonly List<string> audioPudge = new List<string>();
    private readonly List<string> audioPudgeFootsteps = new List<string>();
    private bool back = false;
    private int time = 0;
    private int iter = 0;
    private int opr = 1;
    private void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;
        gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>($"Sounds/{game.languageSounds}/Pudge/Voice/Pud_move");
        gameObject.GetComponent<AudioSource>().Play();
        audioPudge.Add($"Sounds/{game.languageSounds}/Pudge/Voice/Pudge1");
        audioPudge.Add($"Sounds/{game.languageSounds}/Pudge/Voice/Pudge2");
        audioPudge.Add($"Sounds/{game.languageSounds}/Pudge/Voice/Pudge3");
        audioPudge.Add($"Sounds/{game.languageSounds}/Pudge/Voice/Pudge4");
        audioPudge.Add($"Sounds/{game.languageSounds}/Pudge/Voice/Pudge5");
        audioPudgeFootsteps.Add("Sounds/ALL/Pudge/Steps/Footstep1");
        audioPudgeFootsteps.Add("Sounds/ALL/Pudge/Steps/Footstep2");
        audioPudgeFootsteps.Add("Sounds/ALL/Pudge/Steps/Footstep3");
        audioPudgeFootsteps.Add("Sounds/ALL/Pudge/Steps/Footstep4");
    }

    public void playSound()
    {
        iter++;
        if (iter == 10)
        {
            back = true;
            gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>($"Sounds/{game.languageSounds}/Pudge/Voice/Pud_respawn");
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Button>().interactable = false;
            gameObject.transform.Rotate(new Vector3(0, 0, 5 * opr));
        }
        else
        {
            gameObject.transform.Rotate(new Vector3(0, 0, 5 * opr));
            gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>(audioPudge[UnityEngine.Random.Range(0, audioPudge.Count)]);
            gameObject.GetComponent<AudioSource>().Play();
        }
        opr *= -1;
    }

    private void FixedUpdate()
    {
        time++;
        if(back == false)
        {
            if (gameObject.GetComponent<RectTransform>().anchoredPosition.x > -410)
            {
                if (time % 20 == 0 && gameObject.GetComponent<RectTransform>().anchoredPosition.x > -400)
                {
                    game.AudioManager(Resources.Load<AudioClip>(audioPudgeFootsteps[UnityEngine.Random.Range(0, audioPudgeFootsteps.Count)]));
                }
                if (time % 10 == 0)
                {
                    opr *= -1;
                }
                gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x - 10, gameObject.transform.localPosition.y - 5 * opr, gameObject.transform.localPosition.z);

            }
            else
            {
                gameObject.GetComponent<Button>().interactable = true;
            }
        }    
        else if(back == true)
        {
            gameObject.GetComponent<Button>().interactable = false;
            if (gameObject.GetComponent<RectTransform>().anchoredPosition.x < 600)
            {
                if (time % 20 == 0 && gameObject.GetComponent<RectTransform>().anchoredPosition.x < 600)
                {
                    game.AudioManager(Resources.Load<AudioClip>(audioPudgeFootsteps[UnityEngine.Random.Range(0, audioPudgeFootsteps.Count)]));
                }
                if (time % 10 == 0)
                {
                    opr *= -1;
                }
                gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x + 10, gameObject.transform.localPosition.y - 5 * opr, gameObject.transform.localPosition.z);
            }
        }
        
    }
}
