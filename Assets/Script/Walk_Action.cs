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
    public Camera cam1;
    public Camera cam2;
   public GameObject pauseObjects;


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

    public void RootateScene()
    {
        Character.transform.Rotate(0, -90, 0);
        if (cam1.enabled == true)
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }
        else
        {
            cam2.enabled = false;
            cam1.enabled = true;
        }
    }
    public void pauseGame()
    {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
            pauseObjects.SetActive(true);
            }
            else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseObjects.SetActive(false);
        }
    }
}
