using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    
    void FixedUpdate()
    {
        float horizontalMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        MoveV(verticalMove);
        MoveH(horizontalMove);
    }

    void MoveH(float horizontalMove)
    {
        Vector3 targetVelocity = new Vector2(horizontalMove,rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }

    void MoveV(float verticalMove)
    {
        Vector3 targetVelocity= new Vector2(rb.velocity.x,verticalMove);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velocity, .05f);
    }
    
}
