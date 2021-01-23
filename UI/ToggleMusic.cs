using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleMusic : MonoBehaviour
{
    [SerializeField] public AudioMixerGroup mixerMusic = null;
    [SerializeField] private AudioClip audioToggleMusic = null;
    [SerializeField] Game game = null;
    bool flag = false;

    private void Start()
    {
        if (game.musicSetting == true)
        {
            game.musicSetting = true;
            gameObject.GetComponent<Toggle>().isOn = true;
            mixerMusic.audioMixer.SetFloat("MusicVolume", -10);
        }
        else
        {
            game.musicSetting = false;
            gameObject.GetComponent<Toggle>().isOn = false;
            mixerMusic.audioMixer.SetFloat("MusicVolume", -80);
        }
        flag = true;
    }

    public void SetMusic(bool choice)
    {
        if(choice)
        {
            game.musicSetting = choice;
            gameObject.GetComponent<Toggle>().isOn = true;
            mixerMusic.audioMixer.SetFloat("MusicVolume", -10);
        }
        else
        {
            game.musicSetting = choice;
            gameObject.GetComponent<Toggle>().isOn = false;
            mixerMusic.audioMixer.SetFloat("MusicVolume", -80);
        }
    }

    public void СhangeMusic()
    {
        if (gameObject.GetComponent<Toggle>().isOn)
        {
            SetMusic(true);
        }          
        else
        {
            SetMusic(false);
        }
        if (flag)
        {
            game.AudioManager(audioToggleMusic);
            game.xmlData.SaveSetting();
        }
    }
}
