using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    [SerializeField]
    private Transform asd;
    private Vector3 kameraKonumu;
    void Start()
    {
        asd = GameObject.FindGameObjectWithTag("uzgunAdam").transform;
        kameraKonumu = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 istenenKonum = asd.position + kameraKonumu;
        transform.position = Vector3.MoveTowards(transform.position, istenenKonum, 3f * Time.deltaTime);
    }
}
