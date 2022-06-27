using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball1 : MonoBehaviour
{
    float speed = 15f;
    // Start is called before the first frame update

        float hit (Vector2 Pball,Vector2 rak,float HArak)
    {
        return (Pball.x-rak.x)/HArak;
    }

void OnCollisionEnter2D(Collision2D cal)
    {
        if (cal.gameObject.name == "game")
        {

            float r = hit(transform.position, cal.transform.position, cal.collider.bounds.size.x);
            Vector2 dir = new Vector2(r,1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (cal.gameObject.tag == "hit")
        {
            Destroy(cal.gameObject);
        }



    }



    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
