using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public GameOver GameOver;
    int health = 0;

    public void GameOverview(){
        GameOver.Setup();
    }
}
