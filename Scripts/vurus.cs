using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vurus : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ölü")
        {
            collision.gameObject.GetComponent<dusmanCani>().canKaybi(4f); //4f bir can kaybı olacak.
        }
    }
}
