using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public GameObject UIObject;
    public int seconds;
    


    void Start()
    {
        UIObject.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);
            StartCoroutine("WaitForSec");
           
        }
        
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(seconds);
        UIObject.SetActive(false);
        Destroy(UIObject);
        Destroy(gameObject);
    }

}
