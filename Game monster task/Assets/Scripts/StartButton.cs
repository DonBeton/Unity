using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [SerializeField] private PauseMenu _pauseGameMenu;

    public void StartGame()
    {
        _pauseGameMenu.Resume();
    }
}
