using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDeveloperMessage : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text = null;
    private bool flag = false;
    private int time = 0;

    private void FixedUpdate()
    {
        time++;
        if (time > 10)
        {
            time = 0;
            flag = !flag;
        }
        if (flag == true)
        {
            text.transform.localScale = new Vector3(text.transform.localScale.x + 0.005f, text.transform.localScale.y + 0.005f, text.transform.localScale.z + 0.005f);
        }
        else if (flag == false)
        {
            text.transform.localScale = new Vector3(text.transform.localScale.x - 0.005f, text.transform.localScale.y - 0.005f, text.transform.localScale.z - 0.005f);
        }
        text.rectTransform.localPosition = new Vector3(0, text.rectTransform.localPosition.y - 2, 0);
        if (text.rectTransform.localPosition.y < -1300) gameObject.SetActive(false);
    }
}
