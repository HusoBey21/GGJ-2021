using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atesleme : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform mermi;
    [SerializeField]
    private AudioSource sesKaynagi;
    [SerializeField]
    private AudioClip sesKlibi;
    void Start()
    {
        mermi = GameObject.FindGameObjectWithTag("Lazer").transform;
        sesKaynagi = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if(mermi !=null)
            {
                sesKaynagi.clip = sesKlibi;
                if(!sesKaynagi.isPlaying)
                {
                    sesKaynagi.Play(); 
                }
                Transform sd = Instantiate(mermi, transform.position, Quaternion.identity) as Transform;
                Destroy(sd.gameObject, 7f);
            }
            
        }
    }
}
