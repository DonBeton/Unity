using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject _pauseGameMenu;
    public bool PauseGame;
    
    private void Start() 
    {
        Pause();
    }
    public void Resume()
    {
        _pauseGameMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        _pauseGameMenu.SetActive(true);
        Time.timeScale = 0;
    }
}
