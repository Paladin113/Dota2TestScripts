using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections.Generic;

public class ButtonRestartGame : MonoBehaviour
{
    [SerializeField] private GameObject blackout1100EndTest = null;
    [SerializeField] public AudioMixerGroup mixerMusic = null;
    [SerializeField] Game game = null;
    private bool flag = false;
    private int time;
    public void StartEndTest()
    {
        flag = !flag;
        blackout1100EndTest.SetActive(true);

    }

    private void FixedUpdate()
    {
        if (flag)
        {
            time++;
            if (time * 0.02 > 1)
            {
                SceneManager.LoadScene("Main", LoadSceneMode.Single);
                flag = !flag;
            }
            else
            {
                Game.startWhith = "";
                if (game.musicSetting)
                {
                    mixerMusic.audioMixer.SetFloat("MusicVolume", -time - 10);
                }
                if (game.soundSetting)
                {
                    mixerMusic.audioMixer.SetFloat("SoundVolume", -time);
                }
            }
        }
    }
}
