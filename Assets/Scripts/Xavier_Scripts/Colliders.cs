using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Colliders : MonoBehaviour
{
    public bool CanPress;

    public int index;
    public float ScoreValue;
    Text score;

   
    public Animator anim;

    public GameObject guiObject;

    private void Start()
    {
        ScoreValue = 0;
        score = GetComponent<Text>();
    }

    private void Update()
    {
        score.text = "Score: " + ScoreValue;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Arrows"))
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                ScoreValue += 5;
            }
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}

