using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip normal;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = normal;
        audio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
