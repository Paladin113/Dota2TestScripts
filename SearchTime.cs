using System;
using UnityEngine;
using UnityEngine.UI;

public class SearchTime : MonoBehaviour
{
    [SerializeField] private GameObject searhElement = null;
    [SerializeField] private GameObject acceptTest = null;
    [SerializeField] private GameObject blackout = null;
    [SerializeField] private GameObject buttonAcceptTest = null;
    [SerializeField] private GameObject acceptParticleEffects = null;
    [SerializeField] private AudioClip audioMatchReady = null;
    [SerializeField] private Game game = null;
    private int maxTime;
    [NonSerialized] public int time;

    void Start()
    {
        maxTime = 5 + UnityEngine.Random.Range(0, 4);
        time = 0;
    }

    void FixedUpdate()
    {
        time++;
        gameObject.GetComponent<Text>().text = $"0:0{time * 0.02 % 60:0}";
        if (time * 0.02 > maxTime && time * 0.02 < maxTime + 0.05)
        {
            acceptTest.SetActive(true);           
            acceptParticleEffects.SetActive(true);
        }
        else if (time * 0.02 > maxTime + 0.05)
        {
            game.AudioManager(audioMatchReady);
            blackout.SetActive(true);
            buttonAcceptTest.gameObject.SetActive(true);
            searhElement.gameObject.SetActive(false);
        }
    }
}
