using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalCode : MonoBehaviour
{
    AudioSource finalAudio;

    // Start is called before the first frame update
    void Start()
    {
        finalAudio = GameObject.Find("iesire_joc").GetComponent<AudioSource>();
        finalAudio.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
