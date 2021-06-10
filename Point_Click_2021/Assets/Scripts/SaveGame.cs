using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
public class SaveGame : MonoBehaviour
{
    public InputField inputText;
    public Button button;
    string GameName;

    public static int GameId = 0;


    void Start()
    {
      GameName = PlayerPrefs.GetString("GameNameKey");
      inputText.text = GameName;
    }

    public void SaveName()
    {
        GameName = inputText.text;
        PlayerPrefs.SetString("GameNameKey", GameName);
    }
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
