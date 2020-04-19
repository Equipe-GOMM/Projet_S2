using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;



public class Health : MonoBehaviour

{

    public float health;     // quantité de coeur visibles

    public int numberOfHearts;   // stock de coueurs visibles et non visible



    public Image[] hearts;   // array d'image

    public Sprite FullHeart;  // sprite du coeur pleins 

    public Sprite EmptyHeart;  // sprite du coeur vide 

    public GameObject gameoverUI;



     void Start()

    {

        gameoverUI.SetActive(false);

    }



    public void TakeDamage(float amount)

    {

        health -= amount;

    }

    void Update()

    {



        if(health == 0)

        {

            Destroy(gameObject);
            gameoverUI.SetActive(true);



        }

        if(health > numberOfHearts)  //Evite qu'on ai plus de coeur que prévus

        {

            health = numberOfHearts;

        }

        for (int i = 0; i < hearts.Length; i++)  // Tant que la variable i est inférieur au nombre de coeur de mon array

        {

            if (i < health)

            {

                hearts[i].sprite = FullHeart;   // Image du coeur remplis tant que l'index est inférieur à notre vie 

            }

            else

            {

                hearts[i].sprite = EmptyHeart; // Image du coeur vide quand l'index est plus grand que notre vie

               

            }



            if(i < numberOfHearts)     

            {

                hearts[i].enabled = true;   // rendre visible le coeur 

            }

            else

            {

                hearts[i].enabled = false;  // rendre invisible le coeur

            }

        }  

    }

}