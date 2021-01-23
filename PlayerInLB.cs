using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInLB : MonoBehaviour
{
    public RectTransform rectTransform = null;
    public Text textPos = null;
    public Text textName = null;
    public Text textRating = null;
    public Text textTime = null;

    public void SetPlayerInLB(int pos, string name, int rating, int time)
    {
        textPos.text = pos.ToString();
        textName.text = name;
        textRating.text = $"{rating} ммр";
        textTime.text = $"{time / 60} м. {time % 60} с."; ;
    }
}
