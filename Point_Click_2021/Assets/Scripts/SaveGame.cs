using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{
   [SerializeField] private GameObject unitGameObject;
   private IUnit unit;

   private void Save(){
    //Save
    Vector2 playerPosition = unit.GetPosition();
    int Inventory = unit.GetInv_Amount(); // Wie viele Items im Inventory sind 
    string [] Items = {"Axt", "Leber", "Niere"}; // Was für welche Items im Inventory ist und beim laden wird dann das zugehörige Bild geladen
    Debug.Log("Items in Inventory: "+ Items);
    int last_scene = SceneManager.GetActiveScene().buildIndex;

    SaveObject saveObject = new SaveObject{
      last_scene = last_scene,
      inv_Amount = Inventory,
      Items = Items,
      playerPosition = playerPosition
    };

    string json = JsonUtility.ToJson(saveObject);
    Savesystem.Save(json);
    Debug.Log("Saved!!");

   }

  private void Load() {
    string savestring = Savesystem.Load();
    if(savestring != null){
      //Debug.Log("Loaded: "+ savestring);
      
      SaveObject saveObject = JsonUtility.FromJson<SaveObject>(savestring);

      unit.SetPosition(saveObject.playerPosition);
      unit.Setinv_Amount(saveObject.inv_Amount);
      unit.SetlastScene(saveObject.last_scene);
      unit.SetItems(saveObject.Items);
  } else{
    Debug.Log("There are no SaveGames");
  }
  }
  public class SaveObject {
    
    public int last_scene;
    public int inv_Amount; //Wie viele Items im Inventory
    public string [] Items;
    public Vector2 playerPosition;
  } 
}
