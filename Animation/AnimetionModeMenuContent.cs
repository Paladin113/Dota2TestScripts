using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimetionModeMenuContent : MonoBehaviour
{
    private bool flag = true;
    private int time;
    [SerializeField] private RectTransform rectTransform = null;

    public void OpenAboutContent()
    {
        rectTransform.anchoredPosition = new Vector2(0, 0);
        time = 0;
        flag = true;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            time = 0;
            flag = false;
        }
        if (flag)
        {
            time++;
            if (time * 0.02 > 1)
            {
                rectTransform.anchoredPosition = new Vector3(rectTransform.anchoredPosition.x-1, rectTransform.anchoredPosition.y);

            }
        }
    }
}
