using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonPlayOfflineAnimation : MonoBehaviour
{
    [SerializeField] private Button buttonPlayOffline = null;
    [SerializeField] private Text textButtonPlayOffline = null;
    [SerializeField] private Loading loading = null;
    private void FixedUpdate()
    {
        if (loading.playOffline == false && buttonPlayOffline.image.color.a < 1)
        {
            buttonPlayOffline.image.color = new Color(1, 1, 1, buttonPlayOffline.image.color.a + 0.08f);
            textButtonPlayOffline.color = new Color(1, 1, 1, buttonPlayOffline.image.color.a + 0.08f);
        }
        else if (loading.playOffline == true && buttonPlayOffline.image.color.a > 0)
        {
            buttonPlayOffline.image.color = new Color(1, 1, 1, buttonPlayOffline.image.color.a - 0.08f);
            textButtonPlayOffline.color = new Color(1, 1, 1, buttonPlayOffline.image.color.a - 0.08f);
            buttonPlayOffline.interactable = false;

        }
    }
}
