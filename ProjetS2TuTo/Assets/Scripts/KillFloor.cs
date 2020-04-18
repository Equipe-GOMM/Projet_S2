using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{
    [SerializeField] Transform spawnpoint;    //permet de mettre en place un point de spawn 

    void OnCollisionEnter2D(Collision2D col)    //si col est un joueur , alors le joueur va prendre la position de spawnpoint
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = spawnpoint.position;

        }
    }
}
