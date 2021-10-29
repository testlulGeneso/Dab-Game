using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;
public class Colliders : MonoBehaviour
{


    public bool CanPress;

    public int index;
    public float Score;

   
    public Animator anim;

    public GameObject guiObject;

    private void Start()
    {
        Score = 0;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arrows"))
        {
            

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Score += 5;
            }

          

        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }

   


}

