using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
