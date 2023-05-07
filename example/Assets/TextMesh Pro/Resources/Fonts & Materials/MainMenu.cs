using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // this loads a new scene 
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
    
    public void SwapPanel(GameObject selected)
    {
        GameObject[] canvasList = GameObject.FindGameObjectWithTag("UiCanvas");
        foreach(GameObject canvas in canvasList)
        {
            canvas.SetActive(false);
        }

        selected.SetActive(true);
    }

}
