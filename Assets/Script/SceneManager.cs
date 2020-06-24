using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject Scene;

    public void RotateScene()
    {
        Scene.transform.Rotate(0, 90, 0);
    }
}
