using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    public GameObject UIObject;



    void Start()
    {
        UIObject.SetActive(true);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            UIObject.SetActive(false);
            

        }

    }
}
