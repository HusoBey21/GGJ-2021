using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ilerleme : MonoBehaviour
{

   
    
    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right"))
        {
            transform.eulerAngles = new Vector3(0f,180f,0f);

            transform.position += Vector3.right * 1f;
        }
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left"))
        {
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
            transform.position += Vector3.left *1f;
        }
        if(Input.GetKeyDown("space"))
        {
            transform.position += Vector3.up * 3f;
        }
        if(Input.GetKeyUp("space"))
        {
            transform.position += Vector3.down * 3f;
        }
        if(Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(0);
        }
       
        
    }
   
}
