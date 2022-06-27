using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    
        
    public int Rayen (int a ,int b)
    {
         
        int c = a + b;
        return c;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Rayen(100, 5));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
