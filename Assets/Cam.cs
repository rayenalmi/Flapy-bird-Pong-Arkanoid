using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public Transform Bird;
    Vector3 ran;

    // Start is called before the first frame update
    void Awake()
    {
        ran = transform.position - Bird.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      transform.position= new Vector3 ( ran. x+ Bird.position.x, transform.position.y,ran.z+Bird.position.z);
    }
}
