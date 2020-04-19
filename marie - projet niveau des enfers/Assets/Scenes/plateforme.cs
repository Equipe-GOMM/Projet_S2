using UnityEngine;

using System.Collections;



public class plateforme : MonoBehaviour

{

    [SerializeField]

    float moveSpeed = 1f;

    Rigidbody2D platformRigidBody;

    bool End = true;

    

    



    private void OnCollisionEnter2D(Collision2D collision)

    {

        if(collision.gameObject.tag == "Player")

        {

            collision.collider.transform.SetParent(transform);

        }

    }



    private void OnCollisionExit2D(Collision2D collision)

    {

        if(collision.gameObject.tag == "Player")

        {

            collision.collider.transform.SetParent(null);

        }

        

    }



    void Start()

    {

        platformRigidBody = GetComponent<Rigidbody2D>();

        End = false;



    }



     void FixedUpdate()

    {

        StartCoroutine("Wait");

    }



    IEnumerator Wait()

    {

        if (!End)

        {

            Right();

            yield return new WaitForSeconds(2);

            End = true;

        }

        else if (End)

        {

            left();

            yield return new WaitForSeconds(2);

            End = false;

        }

    }



    private void Right()

    {

        platformRigidBody.velocity = new Vector2(moveSpeed, 0f);

    }

    private void left()

    {

        platformRigidBody.velocity = new Vector2(-moveSpeed, 0f);

    }

}
