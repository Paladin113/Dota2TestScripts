﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackoutTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            gameObject.SetActive(false);
        }
    }
}
