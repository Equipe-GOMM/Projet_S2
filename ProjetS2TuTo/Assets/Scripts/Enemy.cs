using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;   // permet de modifier la santé 

    

    public float speed;   //modifie la vitesse
    private bool movingRight = true;  //variable qui permet de savoir si le personnage avance vers la droite
    public Transform groundDetection;  //variable qui va détecter le sol
    public float distance;      //largeur du trait 

   
    void Update()
    {
       if(health <= 0)       //si la santé est négative ou nul , alors l'ennemi disparaît
        {
            Destroy(gameObject);
        }
        transform.Translate(Vector2.right   * speed * Time.deltaTime); //l'ennemi se déplace à droite automatiquemen

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance); //emmet un trait immaginaire verticale vers le bas
        if(groundInfo.collider == false)  //si le block n'est plus un sol
        {
            if (movingRight == true)  //si on se déplace à droite , alors on pivote à gauche
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0,0);   //si on se déplace à gauche , alors on pivote à droite
                movingRight = true;


            }

        }
    }

    public void TakeDamage(int damage)    //on retire des points de vie 
    {
        health -= damage;
        Debug.Log("damage TAKEN !");
    }



}
