using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    [SerializeField] private AudioSource Audio;
    [Space]
    [SerializeField] private AudioClip Hook;
    [SerializeField] private AudioClip Main;

    public void StartMusic()
    {
        StartCoroutine(_MusicLoop());
    }

    private IEnumerator _MusicLoop()
    {
        Audio.PlayOneShot(Hook);
        while (Audio.isPlaying)
        {
            yield return null;
        }

        Audio.clip = Main;
        Audio.loop = true;
        Audio.Play();
    }
}
