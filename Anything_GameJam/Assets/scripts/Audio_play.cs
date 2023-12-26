using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_play : MonoBehaviour
{
    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Au_Play()
    {
        AS.Play();
    }
}
