using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour

{
    void OnTriggerExit2D (Collider2D ray)
    {
        if (ray.gameObject.tag == "bird")
        {
            transform.position = transform.position + (2*Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x);
        }
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
