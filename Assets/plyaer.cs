using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plyaer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float s = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        transform.Translate(s * 0.2f, 0, 0);



    }
}
