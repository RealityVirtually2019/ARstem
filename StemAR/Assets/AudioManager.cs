using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioClip[] clips;

    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void audioPlay(int x)
    {
        audio.clip = clips[x];
        audio.Play();
    }

    public void audioStop()
    {
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

}