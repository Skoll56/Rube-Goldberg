using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speech : MonoBehaviour {
    bool talking = false;
    int lineNo = 0;
    public AudioClip[] line = new AudioClip[20];
    private AudioSource source;

    // Use this for initialization
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

 
    void Update()
    {
        if (source.isPlaying == false)
        {
           gameObject.SetActive(false);
           // talking = true;
        }
       
        
    }

    public void SayLine()
    {
        gameObject.SetActive(true);
        source.PlayOneShot(line[lineNo], 1);
        lineNo++;
    }
}
