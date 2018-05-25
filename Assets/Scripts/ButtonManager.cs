using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void CloseApp()
    {
        Application.Quit();
    }
    public void StopGame() {
        SceneManager.LoadScene("EndScene");
    }
}
