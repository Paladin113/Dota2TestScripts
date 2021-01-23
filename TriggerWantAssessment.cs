using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWantAssessment : MonoBehaviour
{
    [SerializeField] private GameObject backgroundGrey = null;
    [SerializeField] private GameObject WantAssessment = null;
    [SerializeField] public bool activeTrig = false;
    private int time = 0;
    public void activeTrigger()
    {
        WantAssessment.SetActive(true);
    }


    private void FixedUpdate()
    {
        if (activeTrig)
        {
            time++;
            if (time * 0.02 % 60 < 1.3)
            {
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a - 0.03f);
            }
        }        
    }
}
