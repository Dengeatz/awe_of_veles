using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    private AudioSource walk_AudioSource;
    [SerializeField] private AudioClip[] audio_clips;
    private int iterate_id = 0; 
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
        {
            walk_AudioSource ??= this.transform.AddComponent<AudioSource>();
            if (iterate_id <= 1)
            {
                PlaySound();
            } else
            {
                iterate_id = 0;
            }
        } else
        {
            Destroy(walk_AudioSource);
            walk_AudioSource = null;
        }
    }

    void PlaySound()
    {
        walk_AudioSource.loop = false;
        walk_AudioSource.playOnAwake = false;
        walk_AudioSource.volume = 0.1f;
        if (walk_AudioSource.isPlaying == false)
        {
            walk_AudioSource.clip = audio_clips[iterate_id++];
            walk_AudioSource.PlayOneShot(walk_AudioSource.clip);
        }
    }
}
