using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerRIght : MonoBehaviour
{

    public bool test;

    public Scoring score;

    private void Start()
    {
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
            score.score += 5;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        test = false;
    }
}
