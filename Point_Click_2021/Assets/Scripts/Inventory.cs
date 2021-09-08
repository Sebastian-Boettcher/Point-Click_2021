using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Inventory
{
    public event EventHandler OnItemListChanged;
    private List<Item> itemList;
    
    public Inventory(){
        itemList = new List<Item>();
        
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
        OnItemListChanged?.Invoke(this, EventArgs.Empty);
    }
    public List<Item> GetItemList(){
        return itemList;
    }
    public void CombineItems(Item Give, Item Get){
        
    }

}
