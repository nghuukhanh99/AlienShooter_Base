using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FxType
{
    Shoot = 0,
    EnemyDie = 1,
    PowerUp = 2,
}

public class Ply_SoundManager : Ply_Singleton<Ply_SoundManager>
{
    public AudioClip[] audioClips;
    public AudioSource sound;
    private AudioSource[] fx = new AudioSource[5];

    bool isMute = false;

    public void PlayFx(FxType fxType)
    {
        if (!isMute)
        {
            if (fx[(int)fxType] == null)
            {
                fx[(int)fxType] = new GameObject().AddComponent<AudioSource>();
                fx[(int)fxType].clip = audioClips[(int)fxType];
            }
            fx[(int)fxType].Play();
            Change_Volume_Fx(FxType.EnemyDie, 0.4f);
        }
    }

    public void Mute()
    {
        sound.Stop();
        for (int i = 0; i < fx.Length; i++)
        {
            if (fx[i] != null)
            {
                fx[i].Stop();
            }
        }
    }

    public void Change_Volume_Fx(FxType fxType, float volume)
    {
        if (fx[(int)fxType])
        {
            fx[(int)fxType].volume = volume;
        }
    }
}
