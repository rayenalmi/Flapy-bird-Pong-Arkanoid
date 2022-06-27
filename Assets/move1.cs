using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0.5f, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(0, -0.5f, 0);
        }
    }
}

