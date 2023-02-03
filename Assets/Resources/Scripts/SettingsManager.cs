using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    [SerializeField] private AudioMixer masterMixer;
    
    [SerializeField] private Image musicMark, soundMark;
    
    [SerializeField] private Sprite onMark, offMark;
    
    private bool isMusicOn = true;
    private bool isSoundsOn = true;
    
    public void _MusicToggle()
    {
        isMusicOn = !isMusicOn;
        musicMark.sprite = isMusicOn ? onMark : offMark;
        masterMixer.SetFloat("Music", isMusicOn ? 0f : -80f);
        masterMixer.GetFloat("Music", out var gotMusic);
        Debug.Log($"Music {isMusicOn}, {gotMusic}, {(isMusicOn ? 0f : -80f)}");
    }
    
    public void _SoundsToggle()
    {
        isSoundsOn = !isSoundsOn;
        soundMark.sprite = isSoundsOn ? onMark : offMark;
        masterMixer.SetFloat("FX", isSoundsOn ? 0f : -80f);
        masterMixer.GetFloat("FX", out var gotFx);
        Debug.Log($"FX {isSoundsOn}, {gotFx}, {(isSoundsOn ? 0f : -80f)}");
    }
}
