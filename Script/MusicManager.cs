using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource AsMusic, AsDie, AsJump;
    // Start is called before the first frame update
    void Start()
    {
        PlayMusic();
    }

    // Update is called once per frame
    public void PlayMusic()
    {
        AsMusic.Play();
    }
    public void PlayJump()
    {
        AsJump.Play();
    }
    public void PlayDie()
    {
        AsDie.Play();
    }
}
