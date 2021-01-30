using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunKonusu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Text metin;
    private string yazmak,parcala;
    void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
        yazmak = "Umudunu kaybedersen yine onu bulursun";
        StartCoroutine(yazi());

    }

    // Update is called once per frame
   

    public IEnumerator yazi()
    {
         parcala = "";
       
        for(int t=0;t<yazmak.Length;t++)
        {
            parcala = yazmak.Substring(0, t);
            Debug.Log(parcala);
            metin.text = parcala;
        }
        metin.text += "n";
        yield return new WaitForSeconds(0.1f);
    }
}
