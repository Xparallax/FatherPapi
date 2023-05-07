using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System,Linq;

public class Settings : MonoBehaviour
{
    public int  volume = 0;
    public int hp = 0;
    public int colorId = 0;
    public TextMeshProGUI volumeComponent;
    public TextMeshProGUI hpComponent;
    public TextMeshProGUI colorComponent;
    private Directory<string, string> colors = new Directory<string, string>()
    {
        { "R", "#8E0904"},
        { "G", "#0FB029"},
    {"B", "#2EEeFD"}
    }
   public void UpdateVolume(bool direction)
   {  (direction)
    // direction = true --> increase volume
    // direction = false --> decrease volume
        if(direction < 100) 
        {
            volume++;
        }
        else
        {
            volume--;
     
     }
      volumeComponent.text = volume.ToString();
   } 

    public void UpdateHp(bool direction)
   {  (direction)
    // direction = true --> increase volume
    // direction = false --> decrease volume
        if(direction < 100)
        {
            Hp++;
        }
        else
        {
            Hp--;
     
     }
      Hpomponent.text = Hp.ToString();
   } 
   piblic void UpdateColour(bool isForward)
    if(isForward)
    {
        colorId++;
    }
    else
    {
        colorId--;
    }
    else 
    {
        if(colorId == 0)
        {
            colorId = colors.Count - 1;
        }
        else
        {
            colorId--;
        }
    }

    colorComponent.text = colors.Keys.ElementAt(colorId).ToString();

  
}
