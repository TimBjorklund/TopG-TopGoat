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

        if (instance == null)//om gameobjekt inte finns så gör ett game object 
            instance = this;
            
        else
            {
                Destroy(gameObject);// om game object redan finns förstör det
                return;
            }
        

        DontDestroyOnLoad(gameObject);// gör så att gameobject inte förstörs när den går in i en ny scene 

        foreach (Sound s in sounds)// bara controller på hur ljudet ska låta 
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.priority = s.priority;
        }
    }
    private void Start()
    {
        Play("Theme");// spelar theme när den startar 
    }
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);// hittar sound med namn och spelar det
        s.source.Play();
        isPlaying = true;
        Invoke("ResetPlaying",s.clip.length);
    }

    private void ResetPlaying()
    {
        isPlaying = false;
    }
}
