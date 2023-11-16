using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseandBook : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    public GameObject book;
    public Book Esperar;
    public bool rotar;
    public PlayerLook Look;
    public PlayerMotor Motor;
    public bool isOpen;

    void Start()
    {
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        book.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            if(isOpen)
            {
                CloseBook();
            }
            else
            {
                OpenBook();
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
        }
    }

    void pauseGame()
    {
        pauseMenu.SetActive(true);
        Cursor.visible = true;
        Time.timeScale = 0f;
        isPaused = true;
    }
    
    public void resumeGame()
    {
        pauseMenu.SetActive(false);
        Cursor.visible = false;
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenBook()
    {
        book.SetActive(true);
        Cursor.visible = true;
        Look.xSensitivity = 0;
        Look.ySensitivity = 0;
        Motor.speed = 0;
        isOpen = true;
    }

    public void CloseBook()
    {
        rotar = Esperar.AskRotate(rotar);
        if(rotar == false)
        {
            book.SetActive(false);
            Cursor.visible = false;
            Look.xSensitivity = 10;
            Look.ySensitivity = 10;
            Motor.speed = 5;
            isOpen = false;
        }
        
    }
}
