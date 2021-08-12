using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory;  
   
    private void Awake() {
      inventory = new Inventory();   
      uiInventory.SetInventory(inventory);//X
    }
    
}
