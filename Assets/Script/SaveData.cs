using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("lvl"))
            PlayerPrefs.SetInt("lvl", 1 );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
