using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySteuerung : MonoBehaviour
{
    public Button Inventory;
    public GameObject invent;

    void PauseGame ()
    {
        Time.timeScale = 0;
    }

    void ResumeGame ()
    {
        Time.timeScale = 1;
    }

    public void show_hide_Inv(){
        if(invent.activeSelf){  
            invent.SetActive(false);
            ResumeGame();
        } else {
            invent.SetActive(true);
            PauseGame();
        }
    }

    public void show_hide_PMenu(){
        if(invent.activeSelf){   
            invent.SetActive(false);
            ResumeGame();
        } else {
            invent.SetActive(true);
            PauseGame();
        }
    }

}
