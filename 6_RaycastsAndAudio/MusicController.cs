using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private AudioSource musicPlayer;

    // Start is called before the first frame update
    void Start()
    {
        musicPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            musicPlayer.Play();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            musicPlayer.Stop();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            musicPlayer.Pause();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            musicPlayer.UnPause();
        }
    }
}
