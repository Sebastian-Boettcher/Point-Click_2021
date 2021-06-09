using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class MoveScenes : MonoBehaviour
{
    public void moveOneUp () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void moveOneDown () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }

   public void moveTwoUp () {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }

    public void moveTwoDown () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }

   public void moveFourUp (){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
   }
   public void moveFourDown (){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
   }
}
