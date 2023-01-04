using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
  public void RestartButton(){
SceneManager.LoadScene("SampleScene");
  }

  public void ExitButton(){
SceneManager.LoadScene("MainMenu");
  }
  
  public void Setup(){
    gameObject.SetActive(true);
  }
}
