using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{

    public Scoring score;
    public bool test;
    public Animator anim;

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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && test)
        {
            score.score += 5;
            anim.SetTrigger("Dab_Right");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        test = false;
    }
}
