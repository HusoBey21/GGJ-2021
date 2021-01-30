using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class agaciTasi : MonoBehaviour
{
    [SerializeField]
    private GameObject[] agaclar;

    void Start()
    {
        agaclar = GameObject.FindGameObjectsWithTag("Ağaç");
        Debug.Log(agaclar.Length);

    }

    // Update is called once per frame
    void Update()
    {
       
        agacHavuzu();
    }

    public void agacHavuzu()
    {
        for(int t=0;t<agaclar.Length;t++)
        {
            Debug.Log(agaclar[t].transform.name);
            if(agaclar[t].transform.position.x + 5f < Camera.main.transform.position.x)
            {
                agaclar[t].transform.position = new Vector3((agaclar[t].transform.position.x + 5f), agaclar[t].transform.position.y, agaclar[t].transform.position.z);
                
            }
            if(agaclar[t].transform.position.x + 5f > Camera.main.transform.position.x)
            {
                agaclar[t].transform.position = new Vector3((agaclar[t].transform.position.x - 5f), agaclar[t].transform.position.y, agaclar[t].transform.position.z);
            }
          

        }
    }
}
