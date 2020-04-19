using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    
    [SerializeField] Transform spawn;

    int damage = 1 ; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.transform.position = spawn.position;
            collision.gameObject.GetComponent<Health>().TakeDamage(1);
           

        }
    }
}
