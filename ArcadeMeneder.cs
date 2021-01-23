using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeMeneder : MonoBehaviour
{
    [SerializeField] private YouDied youDied = null;
    [SerializeField] private Game game = null;
    private readonly List<string> audioListAnger = new List<string>();
    private readonly List<string> audioListTakeDmg = new List<string>();
    private readonly List<string> audioListNoMana = new List<string>();
    private readonly List<string> audioListNo = new List<string>();
    private readonly List<string> audioListDeath = new List<string>();
    private readonly List<string> audioListTrueDeath = new List<string>();

    public void SoundCastSpell()
    {
        if(game.audioSource.isPlaying && youDied.mp < 160 && youDied.hp >1)
        {
            game.audioSource.Stop();
            game.AudioManager(Resources.Load<AudioClip>(audioListNoMana[Random.Range(0, audioListNoMana.Count)]));
        }
        if (game.audioSource.isPlaying && youDied.mp > 160 && youDied.hp > 1)
        {
            game.audioSource.Stop();
            game.AudioManager(Resources.Load<AudioClip>(audioListNo[Random.Range(0, audioListNo.Count)]));
        }
    }

    public void SoundTrueDeath()
    {
        game.AudioManager(Resources.Load<AudioClip>(audioListTrueDeath[Random.Range(0, audioListTrueDeath.Count)]));
    }

    public void SoundDeath()
    {
        game.AudioManager(Resources.Load<AudioClip>(audioListDeath[Random.Range(0, audioListDeath.Count)]));
    }

    public void SoundReincarnation()
    {
        game.AudioManager(Resources.Load<AudioClip>("Sounds/ALL/Arcade/WraithKing/Reincarnation"));
    }

    public void SoundLose()
    {
        game.AudioManager(Resources.Load<AudioClip>("Sounds/ALL/Arcade/killed"));
    }
    public void SoundAnger()
    {
        game.AudioManager(Resources.Load<AudioClip>(audioListAnger[Random.Range(0, audioListAnger.Count)]));
    }

    public void SoundTakeDmg()
    {
        if (game.audioSource.isPlaying == false)
        {
            game.AudioManager(Resources.Load<AudioClip>(audioListTakeDmg[Random.Range(0, audioListTakeDmg.Count)]));
        }
    }

    void Start()
    {
        for (int i = 1; i <= 4; i++)
        {
            audioListAnger.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/Anger/Wraith_anger_0{i}");
        }
        for (int i = 1; i <= 5; i++)
        {
            audioListTakeDmg.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/TakeDmg/Wraith_pain_0{i}");
        }
        for (int i = 1; i <= 3; i++)
        {
            audioListNoMana.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/NoMana/Wraith_nomana_0{i}");
        }
        for (int i = 1; i <= 3; i++)
        {
            audioListNo.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/No/Wraith_deny_0{i}");
        }
        for (int i = 1; i <= 4; i++)
        {
            audioListDeath.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/Death/Wraith_death_0{i}");
        }
        for (int i = 1; i <= 5; i++)
        {
            audioListTrueDeath.Add($"Sounds/{game.languageSounds}/Arcade/WraithKing/TrueDeath/Wraith_truedeath_0{i}");
        }
    }
}
