using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavebrulante : MonoBehaviour
{
    [SerializeField] Transform spawn;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = spawn.position;
            other.gameObject.GetComponent<Health>().TakeDamage(0.5f);
        }
    }
}
