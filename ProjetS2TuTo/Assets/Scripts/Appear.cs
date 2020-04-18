using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    public GameObject UIObject;



    void Start()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UIObject.SetActive(true);


        }

    }
}
