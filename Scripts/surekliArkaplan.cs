using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surekliArkaplan : MonoBehaviour
{
    [SerializeField]
    
    private float uzaklik;
    void Start()
    {
        
        uzaklik = 3f; //Maksat mavi bölüm görülmesin.
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x + uzaklik <Camera.main.transform.position.x)
        {
            arkaPlaniTaşi();
        }
        if(transform.position.x + uzaklik >= Camera.main.transform.position.x)
        {
            geriyeDogru();
        }
    }
    public void arkaPlaniTaşi()
    {
        
        transform.position = new Vector3((transform.position.x + uzaklik), transform.position.y, transform.position.z);
    }
    public void geriyeDogru()
    {
        transform.position = new Vector3((transform.position.x - uzaklik), transform.position.y, transform.position.z);
    }
}
