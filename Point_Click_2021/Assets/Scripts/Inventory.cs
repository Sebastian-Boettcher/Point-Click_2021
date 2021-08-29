using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Inventory
{
    private List<Item> itemList;
    
    public Inventory(){
        itemList = new List<Item>();

        AddItem(new Item{itemType = Item.ItemType.Faden, amount = 1});
        AddItem(new Item{itemType = Item.ItemType.Wutpilz, amount = 1});
        AddItem(new Item{itemType = Item.ItemType.Schwert_der_Koenige, amount = 1});
        AddItem(new Item{itemType = Item.ItemType.Bierkrug, amount = 1});

        if(ItemAmount()>=16){
            Debug.Log("Keine Platz mehr!");
         }
    }
    public int ItemAmount(){
        int amount = itemList.Count;
        return amount;
    }

    public void AddItem(Item item){
        itemList.Add(item);
        //OnListChanged?.Invoke(this, EventArgs.Empty);
    }
    public List<Item> GetItemList(){
        return itemList;
    }

}
