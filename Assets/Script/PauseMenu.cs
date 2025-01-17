using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject guide;
    public GameObject pauseMenu;
    public GameObject settings;
    public GameObject controls;
    public GameObject mouseSen;
    public GameObject musicAndSound;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.visible = true;
            guide.SetActive(false);
            Time.timeScale = 0f;
            if(pauseMenu.activeSelf)
            {
                Resume();
            }
            else
            {
                pauseMenu.SetActive(true);
                settings.SetActive(false);
                controls.SetActive(false);
                mouseSen.SetActive(false);
                musicAndSound.SetActive(false);
            }
        }
    }

    public void Resume()
    {
        guide.SetActive(true);
        pauseMenu.SetActive(false);
        settings.SetActive(false);
        controls.SetActive(false);
        mouseSen.SetActive(false);
        musicAndSound.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void LoadSettings()
    {
        pauseMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void LoadControls()
    {
        pauseMenu.SetActive(false);
        controls.SetActive(true);
    }

    public void GoBack()
    {
        pauseMenu.SetActive(true);
        settings.SetActive(false);
        controls.SetActive(false);
        mouseSen.SetActive(false);
        musicAndSound.SetActive(false);
    }

    public void LoadMouseSen()
    {
        mouseSen.SetActive(true);
        musicAndSound.SetActive(false);
    }

    public void LoadMusicAndSound()
    {
        mouseSen.SetActive(false);
        musicAndSound.SetActive(true);
    }
}
