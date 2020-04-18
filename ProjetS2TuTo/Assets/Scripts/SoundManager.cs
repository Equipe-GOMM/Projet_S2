using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip StarSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        StarSound = Resources.Load<AudioClip>("Stars");
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void Playsound(string clip)
    {
        if(clip == "Stars")
        {
            audioSrc.PlayOneShot(StarSound);

        }
             
        
    }
}
