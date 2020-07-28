using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class NextLevel3 : MonoBehaviour
{
    public int nblife = 2;
    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "levelUp")
        {
            print("next level");
            UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-4");
            PlayerPrefs.SetInt("lvl", 4);

        }
        if (hit.gameObject.tag == "ennemy")
        {
            print("hit");
            nblife--;
            transform.position = spawnPos;

        }
    }

}
