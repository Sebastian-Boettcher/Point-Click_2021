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
    public Button m_YourFirstButton, m_YourSecondButton, m_YourThirdButton, start, delete, start_2, delete_2, start_3, delete_3;
    private int s_bool, s2_bool, s3_bool;
    string GameName_1;
    string GameName_2;
    string GameName_3;


    void Start()
    {
      GameName_1 = PlayerPrefs.GetString("GameNameKey_1");
      GameName_2 = PlayerPrefs.GetString("GameNameKey_2");
      GameName_3 = PlayerPrefs.GetString("GameNameKey_3");

//Button Visibility steuern und speichern
      s_bool = PlayerPrefs.GetInt("Start_Bool");
      bool isOn = changing(s_bool);

      start.gameObject.SetActive(isOn);
      delete.gameObject.SetActive(isOn);
//-------------------------------------------------------------------------
      s2_bool = PlayerPrefs.GetInt("Start_Bool_2");
      bool isOn2 = changing(s2_bool);

      start_2.gameObject.SetActive(isOn2);
      delete_2.gameObject.SetActive(isOn2);
//----------------------------------------------------------------------------
      s3_bool = PlayerPrefs.GetInt("Start_Bool_3");
      bool isOn3 = changing(s3_bool);

      start_3.gameObject.SetActive(isOn3);
      delete_3.gameObject.SetActive(isOn3);
//-------------------------------------------------------------------------------

      m_YourFirstButton.onClick.AddListener(SaveName_1);
      m_YourSecondButton.onClick.AddListener(SaveName_2);
      m_YourThirdButton.onClick.AddListener(SaveName_3);
      
      start.onClick.AddListener(StartGame);
      delete.onClick.AddListener(delete_Game_1);

      start_2.onClick.AddListener(StartGame);
      delete_2.onClick.AddListener(delete_Game_2);

      start_3.onClick.AddListener(StartGame);
      delete_3.onClick.AddListener(delete_Game_3);

      text_1.text = GameName_1;
      text_1.text = GameName_1;
      text_3.text = GameName_3;
    }

    bool changing(int s_bool){
      if(s_bool == 1){
        return true;
      } 
      else{
        return false;
      }
    }

    public void StartGame(){
      //Laden des zuletzt gespeicherten Szenenindex: Je nach Stand des Spieles(Neuer Spielstand oder älterer Spielstand) wird eine unterschiedliche Szenegeladen
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void SaveName_1()
    {
      if(GameName_1 == "")
      {
        GameName_1 = inputText.text;
        PlayerPrefs.SetString("GameNameKey_1", GameName_1);
        inputText.text = "";
        text_1.text = GameName_1;
        
        s_bool = 1;
        PlayerPrefs.SetInt("Start_Bool", s_bool);

        bool mode = changing(s_bool);
        Debug.Log(mode);
       
        start.gameObject.SetActive(mode);
        delete.gameObject.SetActive(mode);
        
      }else{
        Debug.Log("Speicherplatz belegt!");
        m_YourFirstButton.interactable = false;
      }
    }

    public void SaveName_2()
    {
      if(GameName_2 == ""){
        GameName_2 = inputText.text;
        PlayerPrefs.SetString("GameNameKey_2", GameName_2);
        inputText.text = "";
        text_2.text = GameName_2;

        s2_bool = 1;
        PlayerPrefs.SetInt("Start_Bool_2", s2_bool);

        bool mode = changing(s2_bool);
        Debug.Log(mode);
       
        start_2.gameObject.SetActive(mode);
        delete_2.gameObject.SetActive(mode);
      }
      else{
        Debug.Log("Speicherplatz belegt!");
        m_YourSecondButton.interactable = false;
      }
    }

    public void SaveName_3()
    {
      if(GameName_3 == ""){
        GameName_3 = inputText.text;
        PlayerPrefs.SetString("GameNameKey_3", GameName_3);
        inputText.text = "";
        text_3.text = GameName_3;

        s3_bool = 1;
        PlayerPrefs.SetInt("Start_Bool_3", s3_bool);

        bool mode = changing(s3_bool);
        Debug.Log(mode);
       
        start_3.gameObject.SetActive(mode);
        delete_3.gameObject.SetActive(mode);
      }
      else{
        Debug.Log("Speicherplatz belegt!");
        m_YourThirdButton.interactable = false;
      }
    }

    public void delete_Game_1(){

      GameName_1 = "";
      PlayerPrefs.SetString("GameNameKey_1", GameName_1);
      Debug.Log("Spielstand 1 gelöscht");
      m_YourFirstButton.interactable = true;
      text_1.text = GameName_1;

      s_bool = 0;
      PlayerPrefs.SetInt("Start_Bool", s_bool);

      bool mode = changing(s_bool);
      Debug.Log(mode);

      start.gameObject.SetActive(mode);
      delete.gameObject.SetActive(mode);
    }

     public void delete_Game_2(){

      GameName_2 = "";
      PlayerPrefs.SetString("GameNameKey_2", GameName_2);
      Debug.Log("Spielstand 2 gelöscht");
      m_YourSecondButton.interactable = true;
      text_2.text = GameName_2;

      s2_bool = 0;
      PlayerPrefs.SetInt("Start_Bool_2", s2_bool);

      bool mode = changing(s2_bool);
      Debug.Log(mode);

      start_2.gameObject.SetActive(mode);
      delete_2.gameObject.SetActive(mode);
    }

     public void delete_Game_3(){

      GameName_3 = "";
      PlayerPrefs.SetString("GameNameKey_3", GameName_3);
      Debug.Log("Spielstand 3 gelöscht");
      m_YourThirdButton.interactable = true;
      text_3.text = GameName_3;

      s3_bool = 0;
      PlayerPrefs.SetInt("Start_Bool_3", s3_bool);

      bool mode = changing(s3_bool);
      Debug.Log(mode);

      start_3.gameObject.SetActive(mode);
      delete_3.gameObject.SetActive(mode);
    }

}