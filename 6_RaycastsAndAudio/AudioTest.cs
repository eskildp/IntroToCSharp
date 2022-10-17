using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    private AudioSource myAudioSource;

    public AudioClip ExplosionSFX;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Plays whatever is set as ExplosionSFX once when pressing Space
        if(Input.GetKeyDown(KeyCode.Space))
        {
            myAudioSource.PlayOneShot(ExplosionSFX);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Plays whatever is set as ExplosionSFX once when hitting another Collider2D
        myAudioSource.PlayOneShot(ExplosionSFX);
    }
}
