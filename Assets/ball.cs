using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    public Text text2;
    public Text text1;
    public float speed = 0.5f;
    int scr1 = 0;
    int scr2 = 0;

    void Start()
    {
    
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }




    float hitFactor(Vector2 ballPos, Vector2 racketPos,
                   float racketHeight)
    {
      
        return (ballPos.y - racketPos.y) / racketHeight;
    }



    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "RacketLeft")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        // Hit the right Racket?
        if (col.gameObject.name == "RacketRight")
        {
            // Calculate hit Factor
            float y = hitFactor(transform.position,
                                col.transform.position,
                                col.collider.bounds.size.y);

            // Calculate direction, make length=1 via .normalized
            Vector2 dir = new Vector2(-1, y).normalized;

            // Set Velocity with dir * speed
            GetComponent<Rigidbody2D>().velocity = dir * speed;           
        }
        if (col.gameObject.name == "bar1")
        {
            scr1++;
            text1.text = scr1.ToString();
        }

        if (col.gameObject.name == "bar2")
        {
            scr2++;
            text2.text = scr2.ToString();
        }

    }
}