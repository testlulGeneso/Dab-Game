using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nameScene;

    public void LoadScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nameScene);
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}