using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    public static bool isPaused = false;

    public GameObject EscapeScreenUI;
    private Rigidbody rb;
  
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (isPaused)
            {
                Resume();
            } else
            {
                Pause();
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Confined;
            }
        }
       
    }

    public void Resume()
    {
        EscapeScreenUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        Cursor.visible = false;
    }

    public void Pause()
    {
        EscapeScreenUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void NewGameClick()
    {
        SceneManager.LoadScene("Level1");
    }

    public void ExitClick()
    {
        Application.Quit();
    }
}