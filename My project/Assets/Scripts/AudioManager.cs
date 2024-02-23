using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake() {

        if (instance == null)
            instance = this;
        else{
            Debug.Log("Duplicate AudioManager found and destroyed.");
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        
        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            Debug.Log($"Created AudioSource for sound: {s.name}");

        }
    }

    void Start() {
        Play("Theme");
    }
    public void Play (string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        if (s.source == null)
        {
            Debug.LogError($"AudioSource for {name} is null.");
            return;
        }
        s.source.Play();
    }
}
