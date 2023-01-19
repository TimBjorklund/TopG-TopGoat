
using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]

public class Sound
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(0f, 1f)]
    public float pitch;
    public bool loop;
    [Range (0f, 10f)]
    public int priority;
    [HideInInspector]
    public AudioSource source;
}
