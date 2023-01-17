using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    public bool isPlaying;
    
    void Awake ()
    {

        if (instance == null)
            instance = this;
            
        else
            {
                Destroy(gameObject);
                return;
            }
        

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch; 
        }
    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        s.source.Play();
        isPlaying = true;
        Invoke("ResetPlaying",s.clip.length);
    }

    private void ResetPlaying()
    {
        isPlaying = false;
    }
}
