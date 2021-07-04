using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.SceneManagement;


public class ButtonListener : MonoBehaviour
{
     public InputField inputText;
    public Text text_1, text_2, text_3;
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, start, delete;
    string GameName_1;
    string GameName_2;
    string GameName_3;


    void Start()
    {
      GameName_1 = PlayerPrefs.GetString("GameNameKey_1");
      GameName_2 = PlayerPrefs.GetString("GameNameKey_2");
      GameName_3 = PlayerPrefs.GetString("GameNameKey_3");

      m_YourFirstButton.onClick.AddListener(SaveName_1);
      m_YourSecondButton.onClick.AddListener(SaveName_2);
      m_YourThirdButton.onClick.AddListener(SaveName_3);

      start.onClick.AddListener(StartGame);
      delete.onClick.AddListener(delete_1);

      text_1.text = GameName_1;
      text_1.text = GameName_1;
      text_3.text = GameName_3;
    }

    public void StartGame(){
      //Laden des zuletzt gespeicherten Szenenindex: Je nach Stand des Spieles(Neuer Spielstand oder älterer Spielstand) wird eine unterschiedliche Szenegeladen
      int lastindex = 5;//Nur zum Test

     if(lastindex != 0){
       SceneManager.LoadScene(lastindex);
     }
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void delete_1(){
      GameName_1 = "";
      PlayerPrefs.SetString("GameNameKey_1", GameName_1);
      Debug.Log("Spielstand 1 gelöscht");
      m_YourFirstButton.interactable = true;
      text_1.text = GameName_1;
    }

    public void SaveName_1()
    {
         if(GameName_1 == "")
      {
        GameName_1 = inputText.text;
        PlayerPrefs.SetString("GameNameKey_1", GameName_1);
        inputText.text = "";
        text_1.text = GameName_1;

      }else{
        Debug.Log("Speicherplatz belegt!");
        m_YourFirstButton.interactable = false;
      }
    }

    public void SaveName_2()
    {
      GameName_2 = inputText.text;
      PlayerPrefs.SetString("GameNameKey_2", GameName_2);
      inputText.text = "";
      text_2.text = GameName_2;
    }

    public void SaveName_3()
    {
      GameName_3 = inputText.text;
      PlayerPrefs.SetString("GameNameKey_3", GameName_3);
      inputText.text = "";
      text_3.text = GameName_3;
    }
}
