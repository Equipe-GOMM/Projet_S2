using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Mouvement2D : MonoBehaviour
{
    private Rigidbody2D rb;    // obtenir un rigidbody
    public float speed;       // permet de modifier la vitesse de déplacement
    public float jumpForce;      // permet de modifier la puissance du saut 
    private float moveInput;     //variable qui nous indiquera la direction
    private float moveInput1;

    private bool facingRight = true;      //variable qui nous indique si notre joueur regarde a droite

    private bool isGrounded;             // variable qui nous indique si notre joueur est sur le sol
    public Transform groundCheck;        //variable modifiable qui nous permettra de placer un repère au pied du joueur pour vérifier si il est en contact avec le sol
    public float checkRadius;            // variable modifiable qui nous permettra de choisir le rayon de notre repère groundCheck
    public LayerMask whatIsGround;        //variable modifiable qui nous permettra d'indiquer grâce à des Layers quel sera notre ground

    private int extraJump;             //Nombre de saut en plus
    public int extraJumpValue;  // Nombre modifiable de saut en plus 

    void Start()
    {
        extraJump = extraJumpValue;        // extrajump prend la valeur de extraJumpValue
        rb = GetComponent<Rigidbody2D>();   // rb va être affecté à un RigidBody2D
    }

    
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); // un cercle imaginaire va se former a la position groundcheck

        moveInput = Input.GetAxisRaw("MoveHorizontal");  //On obtient la valeur x
        moveInput1 = Input.GetAxisRaw("Horizontal");

        Debug.Log(moveInput);      //la console va afficher -1 , 0 ou 1 selon la direction
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(moveInput1 * speed, rb.velocity.y);

            if (facingRight == false && moveInput1 > 0)     // si le joueur regarde à gauche et on avance à droite alors on flip
            {
                Flip();
            }
            else if (facingRight == true && moveInput1 < 0) // si le joueur regarde à droite et on avance à gauche alors flip
            {
                Flip();
            }

        }
        else
        {
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
            if (facingRight == false && moveInput > 0)     // si le joueur regarde à gauche et on avance à droite alors on flip
            {
                Flip();
            }
            else if (facingRight == true && moveInput1 < 0) // si le joueur regarde à droite et on avance à gauche alors flip
            {
                Flip();
            }

        }
    }

    void Update()
    {

        if(isGrounded  == true)        //si le joueur est sur le sol , extraJump reprend sa valeur initiales
        {
            extraJump = extraJumpValue;
        }
        if (((Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKeyDown(KeyCode.Joystick1Button0))) && extraJump > 0))    //Si on appuie sur flèche du haut et extrajump est plus grand que 0 alors on saute
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded == true)  // saut normal
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void Flip()     // permet de flip le joueur sur l'axe des abscisses
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
