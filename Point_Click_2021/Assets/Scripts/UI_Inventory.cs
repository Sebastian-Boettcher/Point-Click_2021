using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
  private Inventory inventory;
  public Transform itemContainer;
  public  Transform itemTemplate;

  private void Awake(){
    //itemContainer = transform.Find("ItemContainer");
    //itemTemplate = itemContainer.Find("ItemTemplate");
  }

  public void SetInventory(Inventory inventory) {
      this.inventory = inventory;
      RefreshItems();
  }

  private void RefreshItems() {
    int x = -14/8;
    int y = 14/8;
    float itemSlotCellSize = 250 ;
    
    foreach (Item item in inventory.GetItemList())
    {
        RectTransform itemSlot = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();//X
        itemSlot.gameObject.SetActive(true);
        itemSlot.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
        Image image = itemSlot.Find("Image").GetComponent<Image>();
        image.sprite = item.GetSprite();
        x++;
        
      if(x > 1){
          y--;
          x = -2;
          
        }
    }
  }
}
