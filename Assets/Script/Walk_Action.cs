using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_Action : MonoBehaviour
{
    public float mvtSpeed = 5.0f;
    public float rotationSpeed = 5.0f;
    public GameObject Character;
    private Animator animator;
    private bool walk = false;

    void Update()
    {
        if (walk == true) {
            Character.transform.Translate(Vector3.forward * Time.deltaTime * mvtSpeed);

        }

    }

    public void SetAnimationWalk()
    {
      mvtSpeed = 3.0f;
        animator = Character.GetComponent<Animator>();
        animator.SetFloat("Walk", 1.0f);
        walk = true;
    }

    public void StopAnimationWalk()
    {
        animator = Character.GetComponent<Animator>();
        animator.SetFloat("Walk", 0.0f);
        walk = false;
        animator.SetBool("Jump", false);
    }
    public void Jump()
    {
        mvtSpeed = 1.0f;
        animator = Character.GetComponent<Animator>();
        animator.SetFloat("Walk", 1.0f);
        animator.SetBool("Jump", true);
        walk = true;
    }

    public void GoBack()
    {
        Character.transform.Rotate(0, 180 , 0);
    }
}
