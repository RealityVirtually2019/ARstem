using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;
    public static bool StartApp = false;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public float audioPlay(int x)
    {
        audio.clip = clips[x];
        audio.Play();
        return audio.clip.length;
    }

    public void audioStop()
    {
        audio.Stop();
    }

    public void audioStop(float time)
    {
        Invoke("audioStop", time);
    }

    // Update is called once per frame
    void Update()
    {

    }

}