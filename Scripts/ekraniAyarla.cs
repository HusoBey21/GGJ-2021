using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ekraniAyarla : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer resim;
    void Start()
    {
        resim = GameObject.FindGameObjectWithTag("Arkaplan").GetComponent<SpriteRenderer>(); // Arkaplanı aldık.
    }

    // Update is called once per frame
    void Update()
    {
        cozunurlugeGore();
    }

    public void cozunurlugeGore()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        float yatayEksen = Camera.main.orthographicSize * 2f*3.5f;
        float duseyEksen = Screen.width * yatayEksen / Screen.height;
        float resimEni = resim.bounds.size.x;
        float resimBoyu = resim.bounds.size.y;
        float x = yatayEksen / resimEni;
        float y = duseyEksen / resimBoyu;
        transform.localScale = new Vector3(x, y, 1f);
    }
}
