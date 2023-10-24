using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWalk : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("Walk",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
