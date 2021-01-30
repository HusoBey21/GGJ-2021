using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class canBilgisi : MonoBehaviour
{
    [SerializeField]
    private float can;
    [SerializeField]
    private Slider canGostergesi;
     void Start()
    {
        canGostergesi = GameObject.FindGameObjectWithTag("Kaydirici").GetComponent<Slider>();
        canGostergesi.value = 1f;
    }
    public void canKaybi(float hasar)
    {
        can -= hasar;
       
        
        canGostergesi.value -= (hasar / 100f);
        
        

        if(can <=0f)
        {
            SceneManager.GetActiveScene();
            can = 0f;
        }
    }

}
