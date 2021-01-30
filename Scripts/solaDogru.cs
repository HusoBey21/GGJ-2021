using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solaDogru : MonoBehaviour
{
    [SerializeField]
    private Transform asd;
    [SerializeField]
    private bool sagaSola;
    private Vector3 konum;
    
    void Start()
    {
        asd = GameObject.FindGameObjectWithTag("uzgunAdam").transform;
        sagaSola = true; //Geçerli
        
        konum = new Vector3(Camera.main.transform.position.x,transform.position.y,transform.position.z);
       
    }

    // Update is called once per frame
    void Update()
    {
       if(sagaSola)
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, asd.position, 3f * Time.deltaTime);
           

        }
       else
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, konum, 3f * Time.deltaTime);
            if(konum.x <=transform.position.x)
            {
                sagaSola = true;
            }
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag(asd.tag))
        {
            sagaSola = false;
          collision.gameObject.GetComponent<canBilgisi>().canKaybi(3f);
        }
    }
}
