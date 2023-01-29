using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoSingleton<SoundSystem>
{
    [SerializeField] private AudioSource mainSource;
    [SerializeField] private AudioClip mainMusic, objectTouch, bar, box;

    public void MainMusicPlay()
    {
        mainSource.clip = mainMusic;
        mainSource.Play();
        mainSource.volume = 70;
    }

    public void MainMusicStop()
    {
        mainSource.volume = 0;
    }

    public void CallObjectTouch()
    {
        mainSource.PlayOneShot(objectTouch);
    }
    public void CallBar()
    {
        mainSource.PlayOneShot(bar);
    }
    public void CallBox()
    {
        mainSource.PlayOneShot(box);
    }
}
