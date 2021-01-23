using UnityEngine;
using UnityEngine.UI;

public class ButtonMail : MonoBehaviour
{
    public Image imageBuffer = null;
    public Text textBuffer = null;
    public bool flag = false;
    public int time;

    public void ClickButtonMail()
    {
        flag = true;
        GUIUtility.systemCopyBuffer = "dk_e2@inbox.ru";
    }

    private void FixedUpdate()
    {
        if (flag)
        {
            time++;
            if (time * 0.02 <= 0.8)
            {
                imageBuffer.gameObject.SetActive(true);
                imageBuffer.color = new Color(1, 1, 1, imageBuffer.color.a + 0.1f);
                textBuffer.color = new Color(1, 1, 1, imageBuffer.color.a + 0.1f);
            }
            else if (time * 0.02 >= 0.8 && time * 0.02 <= 1.6)
            {
                imageBuffer.color = new Color(1, 1, 1, imageBuffer.color.a - 0.1f);
                textBuffer.color = new Color(1, 1, 1, imageBuffer.color.a - 0.1f);
            }
            else
            {
                imageBuffer.gameObject.SetActive(false);
                time = 0;
                flag = !flag;
            }
        }
    }
}
