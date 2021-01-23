using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonOpanURL : MonoBehaviour
{
    public string URL = null;
    public void OpanWeb()
    {
        Application.OpenURL(URL);
    }
}
