using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanCani : MonoBehaviour
{
    [SerializeField]
    private float can;
     void Start()
    {
        can = 100f;
    }
    public void canKaybi(float hasar)
    {
        can -= hasar;
        if(can<=0f)
        {
            can = 0f;
            gameObject.SetActive(false);
        }
        gameObject.SetActive(true);

    }
}
