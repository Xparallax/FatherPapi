using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Settings1 : MonoBehaviour
{
    public int  volume = 0;
    public TextMeshProUGUI volumeComponent;

   public void UpdateVolume(bool direction)
   {    
    // direction = true --> increase volume
    // direction = false --> decrease volume
        if(direction)
        {
            volume++;
        }
        else
        {
            volume--;
        }

        volumeComponent.text = volume.ToString();
   }
}