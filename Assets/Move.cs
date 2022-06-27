using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            transform.Translate(0,0.3f,0);
        }
        if (Input.GetKey(KeyCode.M))
            {
            transform.Translate(0,-0.3f,0);

        }
    }


}
