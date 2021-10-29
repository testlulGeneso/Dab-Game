using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;

    public AudioMixer audioMixerSoundEffects;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetVolumeSoundEffects(float volumeSE)
    {
        audioMixerSoundEffects.SetFloat("volumeSE", volumeSE);
    }
}

