using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{

    public AudioSource _as;

    public AudioClip[] audioSources;

    private void Awake()
    {
        _as = GetComponent<AudioSource>();
    }

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("PlaySound", 2.0f, 7.0f);
    }

            void PlaySound() {

            _as.clip = audioSources[Random.Range(0, audioSources.Length)];
            _as.PlayOneShot(_as.clip);
        }

    }
