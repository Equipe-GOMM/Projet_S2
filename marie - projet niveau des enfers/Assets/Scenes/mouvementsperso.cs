using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvementsperso : MonoBehaviour
{
    float vitesse = 0.2f;
    private int health; 

    void Update () 
        {
             
            if (Input.GetKey("right"))
            {
                right();
            }
             if (Input.GetKey("left"))
            {
                left();
            }

             if (Input.GetKey("space") || Input.GetKey("up"))
             {

                 Jump();
             }

        }
             
        void left()
        {
            transform.Translate(-vitesse, 0, 0);
        }
         
        void right()
        {
            transform.Translate(vitesse, 0, 0);
        }
         
        void Jump()
        {
            transform.Translate(0,0.4f,0);
        } 
    }
