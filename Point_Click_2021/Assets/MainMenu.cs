using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{    
    public static int spielstände = 1;   
    public void PlayGame ()
    {
           if(spielstände == 1)
           {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);  
           }
           else if(spielstände < 1 || spielstände > 1){
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
           }
           
           
    }
    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
    //----------------------------------------------------------------------
    public void NewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void StartNewGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }
    public void New_Back () // Zurückknopf für die Szene NewGame
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //------------------------------------------------------------------------
    public void Options()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2); 
    }
    public void Options_Back() // Zurückknopf für Options
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    //--------------------------------------------------------------------------

    public void Audio(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void AudioBack(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //-----------------------------------------------------------------------

    public void Steuerung(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    public void SteuerungBack(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
}
