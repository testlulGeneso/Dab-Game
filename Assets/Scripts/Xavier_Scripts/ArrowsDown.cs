using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsDown : MonoBehaviour
{
   
    float arrowsSpeed = 10;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime *arrowsSpeed);
       
    }
}
