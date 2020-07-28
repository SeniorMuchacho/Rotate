using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject[] lvlMenu;
    public GameObject optionMenu;
    private int lastlvl = 0;
    private bool opt = false;

    void Start()
    {
        lastlvl = PlayerPrefs.GetInt("lvl");
    }

    void Update()
    {

    }

    public void LunchGame()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-1");
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Play()
    {
        Time.timeScale = 1;
    }

    public void Showlevel()
    {
        int i = 0;
        foreach (GameObject g in lvlMenu)
        {
            if (i < lastlvl)
                g.SetActive(true);
            i++;
        }
    }

    public void ShowOption()
    {
        opt = !opt;
        optionMenu.SetActive(opt);
    }

    public void resetAccount()
    {
        PlayerPrefs.SetInt("lvl", 1);
    }

    public void Acesslvl1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-1");
    }
    public void Acesslvl2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-2");
    }
    public void Acesslvl3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-3");
    }
    public void Acesslvl4()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-4");
    }
    public void Acesslvl5()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("lvl-5");
    }
}


