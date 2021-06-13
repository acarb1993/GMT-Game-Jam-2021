using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    public GameObject menuUI;

    void Start()
    {
        menuUI.SetActive(false);
    }

    
    void Update()
    {
        if (!menuUI.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuUI.SetActive(true);

                Time.timeScale = 0;
            }
        }

        else if(menuUI.activeInHierarchy)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuUI.SetActive(false);

                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        menuUI.SetActive(false);

        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }

    public void Credits()
    {
        SceneManager.LoadScene(2);
    }
}
