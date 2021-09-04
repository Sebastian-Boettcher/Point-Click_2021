using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ItemWorld : MonoBehaviour
{
    private Item item;
    private Inventory inventory;
    [SerializeField] private UI_Inventory uiInventory; 

    private void Awake() {
        inventory = new Inventory();
    }
   public Item GetItem(){
        return item;
   }
    public void DestroySelf(){
        inventory.AddItem(new Item{itemType = Item.ItemType.Faden, amount = 1});
        Destroy(gameObject);
    }

}
