using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
    public InputField inputText;
    public Text text_1, text_2, text_3;
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton;
    string GameName_1;
    string GameName_2;
    string GameName_3;

    public static int GameId = 0;

    void Start()
    {
      GameName_1 = PlayerPrefs.GetString("GameNameKey_1");
      GameName_2 = PlayerPrefs.GetString("GameNameKey_2");
      GameName_3 = PlayerPrefs.GetString("GameNameKey_3");

      m_YourFirstButton.onClick.AddListener(SaveName_1);
      m_YourSecondButton.onClick.AddListener(SaveName_2);
      m_YourThirdButton.onClick.AddListener(SaveName_3);
      
      text_1.text = GameName_1;
      text_2.text = GameName_2;
      text_3.text = GameName_3;
      
    }

    public void SaveName_1()
    {
      if(text_1.text == ""){
        print("Willst du wirklich einen Neuen Spielstand erstellen? \n");
        print("Neuer Spielstand erstellt!\n");
        print("Y/N");
      }
      else{
      GameName_1 = inputText.text;
      PlayerPrefs.SetString("GameNameKey_1", GameName_1);
      }
    }

    public void SaveName_2()
    {
      GameName_2 = inputText.text;
      PlayerPrefs.SetString("GameNameKey_2", GameName_2);
    }

    public void SaveName_3()
    {
      GameName_3 = inputText.text;
      PlayerPrefs.SetString("GameNameKey_3", GameName_3);
    }
/*
    public void choosePath(){
      if(test.text == " "){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
      else{
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
      }
    }
    */
    /*
    public int CountGames()
    {
      if(GameId >= 3){
        button.interactable =false;
      }
      else{
        GameId++;
        Debug.Log(GameId);
        return GameId;
      }
    }

    */
}
