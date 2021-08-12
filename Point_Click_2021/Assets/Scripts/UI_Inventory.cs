using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
  private Inventory inventory;

  private Transform itemContainer;
  private Transform itemTemplate;

  RectTransform itemSlot;

  private void Awake(){
    itemContainer = transform.Find("ItemContainer");
    itemTemplate = itemContainer.Find("ItemTemplate");
  }

  public void SetInventory(Inventory inventory) {
      this.inventory = inventory;
      RefreshItems();//X
  }

  private void RefreshItems() {
    int x = 0;
    int y = 0;
    float itemSlotCellSize = 40f;
    
    foreach (Item item in inventory.GetItemList())
    {
        
        itemSlot = Instantiate(itemTemplate, itemContainer).GetComponent<RectTransform>();//X
        itemSlot.gameObject.SetActive(true);
        itemSlot.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
        Image image = itemSlot.Find("image").GetComponent<Image>();
        image.sprite = item.GetSprite();
        x++;
        
        if(x > 4){
          y++;
        }
    }
  }

}
