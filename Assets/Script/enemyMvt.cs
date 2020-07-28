using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMvt : MonoBehaviour
{
    public Animator animator;
    private GameObject ActualCheckPoint;
    private bool moving = true;
    public GameObject[] CheckPoint;
    public float speed = 1;
    private Vector3 v_diff;
    private float atan2;
    private
    void Awake()
    {
        ActualCheckPoint = CheckPoint[0];
        transform.position = CheckPoint[0].transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (moving)
        {
            if ((int)ActualCheckPoint.transform.position.x == (int)transform.position.x && (int)ActualCheckPoint.transform.position.z == (int)transform.position.z)
            {
                if ((int)CheckPoint[0].transform.position.x == (int)transform.position.x && (int)CheckPoint[0].transform.position.z == (int)transform.position.z)
                {
                    ActualCheckPoint = CheckPoint[1];
                }
                if ((int)CheckPoint[1].transform.position.x == (int)transform.position.x && (int)CheckPoint[1].transform.position.z == (int)transform.position.z)
                    ActualCheckPoint = CheckPoint[0];
            }
        }
        Vector3 targetPosition = new Vector3(ActualCheckPoint.transform.position.x,
                                             transform.position.y,
                                             ActualCheckPoint.transform.position.z);
        transform.LookAt(targetPosition);
        transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
    }
}
