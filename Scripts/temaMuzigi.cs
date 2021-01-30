using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaMuzigi : MonoBehaviour
{
    [SerializeField]
    private AudioSource sesKaynagi;
    [SerializeField]
    private AudioClip klip;
    void Start()
    {
        sesKaynagi = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        muzikcal();
    }
    public void muzikcal()
    {
        sesKaynagi.clip = klip;
        if(!sesKaynagi.isPlaying)
        {
            sesKaynagi.Play();
        }
    }
}
