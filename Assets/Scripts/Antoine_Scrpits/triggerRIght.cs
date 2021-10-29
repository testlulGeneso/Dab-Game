using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerRIght : MonoBehaviour
{

    public int score;
    public bool test;

    private void Start()
    {
        score = 0;
        test = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        test = true;

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && test)
        {
            score += 5;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        test = false;
    }
}
