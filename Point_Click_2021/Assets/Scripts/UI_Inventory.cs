using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UI_Inventory : MonoBehaviour
{
  private Inventory inventory;
  public Transform itemContainer;
  public  Transform itemTemplate;
  public void SetInventory(Inventory inventory) {
      this.inventory = inventory;
      inventory.OnItemListChanged += Inventory_OnItemListChanged;
      RefreshItems();
  }

  private void Inventory_OnItemListChanged(object sender, System.EventArgs e){
    RefreshItems();
  }

  private void RefreshItems() {
    foreach(Transform child in itemContainer){
      if(child == itemTemplate) continue;
      Destroy(child.gameObject);
    }
    float x = -1.47f;
    float y = 1.4f;
    float itemSlotCellSize = 240f ;  
    foreach (Item item in inventory.GetItemList())
    {
        RectTransform itemSlot = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();//X
        itemSlot.gameObject.SetActive(true);
        itemSlot.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
        Image image = itemSlot.Find("Item").GetComponent<Image>();
        image.sprite = item.GetSprite();
        x++;
        
      if(x > 4.2f){
          y--;  
        }
    }
  }
  public void OnDrop(PointerEventData eventData){
    Debug.Log("On Drop");
    if(eventData.pointerDrag != null){
      eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
    }
  }
}
