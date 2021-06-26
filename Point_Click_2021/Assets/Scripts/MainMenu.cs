using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MainMenu : MonoBehaviour
{    
    public static int spielstände = 0;   
    public void PlayGame ()
    {
           if(spielstände == 1)
           {
               SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);  
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
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3); 
    }
    public void Options_Back() // Zurückknopf für Options
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }
    //--------------------------------------------------------------------------

    public void Audio(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void AudioBack(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    //-----------------------------------------------------------------------

}
