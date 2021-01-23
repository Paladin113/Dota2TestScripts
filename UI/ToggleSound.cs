using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ToggleSound : MonoBehaviour
{
    [SerializeField] public AudioMixerGroup mixerMusic = null;
    [SerializeField] private AudioClip audioToggleSound = null;
    [SerializeField] Game game = null;
    bool flag = false;

    private void Start()
    {
        if (game.soundSetting == true)
        {
            game.soundSetting = true;
            gameObject.GetComponent<Toggle>().isOn = true;
            mixerMusic.audioMixer.SetFloat("SoundVolume", 0);
        }
        else
        {
            game.soundSetting = false;
            gameObject.GetComponent<Toggle>().isOn = false;
            mixerMusic.audioMixer.SetFloat("SoundVolume", -80);
        }
        flag = true;
    }

    public void SetSound(bool choice)
    {
        if (choice)
        {
            game.soundSetting = choice;
            gameObject.GetComponent<Toggle>().isOn = true;
            mixerMusic.audioMixer.SetFloat("SoundVolume", 0);
        }
        else
        {
            game.soundSetting = choice;
            gameObject.GetComponent<Toggle>().isOn = false;
            mixerMusic.audioMixer.SetFloat("SoundVolume", -80);
        }
    }

    public void СhangeSound()
    {

        if (gameObject.GetComponent<Toggle>().isOn)
        {
            SetSound(true);
        }
        else
        {
            SetSound(false);
        }
        if (flag)
        {
            game.AudioManager(audioToggleSound);
            game.xmlData.SaveSetting();
        }
    }
}
