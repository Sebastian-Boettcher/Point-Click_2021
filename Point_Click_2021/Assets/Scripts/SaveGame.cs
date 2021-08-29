using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
   public Inventory inventory;
   private List<Item> itemlist;
   [SerializeField] private UI_Inventory uiInventory;
   SaveObject saveObject;

  private void Awake() {
    inventory = new Inventory();
  }


   public Vector2 Get_Position(){
      Vector2 player = GameObject.Find("Player").transform.position;
      return player;
   }
    public void Set_Position(Vector2 position){
      GameObject.Find("Player").transform.position = position;
   }
    public int Get_LastScene(){
      int l_scene = SceneManager.GetActiveScene().buildIndex;
      return l_scene;
   }
   public void Set_LastScene(int last_scene){
      SceneManager.LoadScene(last_scene);
   }

   public void SetItems( List<Item> itemList){
     saveObject.Items = itemlist;
   }

    public void EndGameMeu(){
        Save();
        Debug.Log("Saved");
        Application.Quit();
    }


   public void Save(){
    Vector2 playerPosition = Get_Position();
    int Inventory = inventory.ItemAmount();// Wie viele Items im Inventory sind 
    List<Item> Items = itemlist; // Was für welche Items im Inventory ist und beim laden wird dann das zugehörige Bild geladen
    Debug.Log(Items);

    Debug.Log("Items in Inventory: "+ Items);
    int lastscene = Get_LastScene();

    saveObject = new SaveObject{
      last_scene = lastscene,
      inv_Amount = Inventory,
      Items = Items,
      playerPosition = playerPosition
    };

    string json = JsonUtility.ToJson(saveObject);
    Savesystem.Save(json);
    Debug.Log("Saved!!");

   }

  public void Load() {
    string savestring = Savesystem.Load();
    if(savestring != null){
      //Debug.Log("Loaded: "+ savestring);
      string GameName = PlayerPrefs.GetString("GameNameKey_1");
      string GameName2 = PlayerPrefs.GetString("GameNameKey_2");
      string GameName3 = PlayerPrefs.GetString("GameNameKey_3");
      
      saveObject = JsonUtility.FromJson<SaveObject>(savestring);

      Set_Position(saveObject.playerPosition);
     //unit.Setinv_Amount(saveObject.inv_Amount);
     Set_LastScene(saveObject.last_scene);
     SetItems(saveObject.Items);
  } else{
    Debug.Log("There are no SaveGames");
  }
  }
  public class SaveObject {
    
    public int last_scene;
    public int inv_Amount; //Wie viele Items im Inventory
    public List<Item> Items;
    public Vector2 playerPosition;
  } 


}
