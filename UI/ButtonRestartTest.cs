using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using System.Collections.Generic;

public class ButtonRestartTest : MonoBehaviour
{
    [SerializeField] private Image blackout1100EndTest = null;
    [SerializeField] public AudioMixerGroup mixerMusic = null;
    [SerializeField] Game game = null;
    [SerializeField] private string startWhith;

    private bool flag = false;
    private int time;
    public void RestartTest()
    {
        Game.startWhith = startWhith;
        flag = !flag;
        blackout1100EndTest.color = new Color(0.102f, 0.110f, 0.157f, 1.000f);     
        blackout1100EndTest.gameObject.SetActive(true);
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
