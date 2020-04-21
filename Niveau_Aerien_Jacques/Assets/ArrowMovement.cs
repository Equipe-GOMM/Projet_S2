using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public float speed;
    public Transform[] waypoints;

    private Vector3 trajectoire;
    private Transform dest;
    public int i;
    
    // Start is called before the first frame update
    void Start()
    {
        trajectoire = waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    { 
        
            Vector3 dir = trajectoire - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime,Space.World);
            i+=1;

    }
    
    
}
