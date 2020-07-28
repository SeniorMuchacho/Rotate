using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManagerFront : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        if (player)
            transform.position = new Vector3(player.transform.position.x  + 10, player.transform.position.y + 5 , player.transform.position.z  );
    }
}
