using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefeDogru : MonoBehaviour
{
    [SerializeField]
    private Transform asd;
    [SerializeField]
    private float mesafe;
    [SerializeField]
    private GameObject prefab = default;
    [SerializeField]
    private Vector3 hedefeDogrum;
    void Start()
    {
        asd = GameObject.FindGameObjectWithTag("uzgunAdam").transform;
        prefab = GameObject.Find("laser");
        mesafe = Random.Range(-4f, 4f);
        hedefeDogrum = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
     void Update()
    {
        bakisAcisi();
    }


    public void bakisAcisi()
    {
        RaycastHit2D o = Physics2D.Raycast(transform.position,hedefeDogrum,3f*Time.deltaTime);
        if (o.transform != null)
        {
            Debug.Log(o.transform.name);


            if (prefab != null)
            {


                if (!o.transform.CompareTag("Lazer"))
                {
                    transform.position = Vector3.MoveTowards(transform.position, o.transform.position, 4f * Time.deltaTime);
                    transform.LookAt(o.transform);
                }
            }
        }
        Physics2D.IgnoreCollision(this.GetComponent<BoxCollider2D>(), asd.gameObject.GetComponent<BoxCollider2D>());
    }
}
