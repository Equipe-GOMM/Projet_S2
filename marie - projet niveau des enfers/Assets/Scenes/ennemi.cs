using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemi : MonoBehaviour
{

    public int health = 3;
    public float speed = 0.1f;
    private bool directiondroite = true;
    public Transform detectersol;
    public float distance; 
    

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D info = Physics2D.Raycast(detectersol.position, Vector2.down, distance);

        if (info.collider == false)
        {
            if (directiondroite == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                directiondroite = false;

            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                directiondroite = true;
            }

        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage taken");
    }
}
