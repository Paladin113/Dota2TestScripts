﻿using UnityEngine;

public class AnimationMiddlegroundEnd : MonoBehaviour
{
    private int time;

    private void FixedUpdate()
    {
        time++;
        if (time * 0.02 > 0.5 && time * 0.02 < 3.5)
        {
            gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x - 10f, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
        }
    }
}
