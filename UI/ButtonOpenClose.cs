using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonOpenClose : MonoBehaviour
{
    [SerializeField] private Game game = null;
    [SerializeField] private GameObject open = null;
    [SerializeField] private GameObject close = null;
    [SerializeField] private AudioClip audioClip = null;
    [SerializeField] private bool escClose = true;


    public void OpanClose()
    {
        game.AudioManager(audioClip);
        open.SetActive(true);
        close.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && escClose)
        {
            gameObject.GetComponent<Button>().onClick.Invoke();
        }
    }
}
