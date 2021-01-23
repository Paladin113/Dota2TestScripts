using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWantAssessmentClose : MonoBehaviour
{
    [SerializeField] private GameObject backgroundGrey = null;
    [SerializeField] private GameObject endTest = null;
    [SerializeField] private GameObject wantAssessment = null;
    [SerializeField] private GameObject triggerWantAssessment = null;

    private int time = 0;
    private bool active = false;

    public void ClickButton()
    {
        active = true;
    }

    private void FixedUpdate()
    {
        if (active)
        {
            time++;
            if (time * 0.02 % 60 < 1.3)
            {
                backgroundGrey.GetComponent<SpriteRenderer>().color = new Color(backgroundGrey.GetComponent<SpriteRenderer>().color.r, backgroundGrey.GetComponent<SpriteRenderer>().color.g, backgroundGrey.GetComponent<SpriteRenderer>().color.b, backgroundGrey.GetComponent<SpriteRenderer>().color.a + 0.03f);
            }
            else if (time * 0.02 % 60 > 1.3 && time * 0.02 % 60 < 2.6)
            {
                endTest.SetActive(true);
                triggerWantAssessment.GetComponent<TriggerWantAssessment>().activeTrig = true;
                wantAssessment.SetActive(false);
            }
        }
    }
}
