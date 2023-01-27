using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoSingleton<SoundSystem>
{
    [SerializeField] private AudioSource mainSource;
    [SerializeField] private AudioClip mainMusic, bloomEffect, goldEffect;

    public void MainMusicPlay()
    {
        mainSource.volume = 70;
    }

    public void MainMusicStop()
    {
        mainSource.volume = 0;
    }

    public void EffectCall()
    {
        mainSource.PlayOneShot(bloomEffect);
    }
    public void EffectGoldCall()
    {
        mainSource.PlayOneShot(goldEffect);

    }
}
