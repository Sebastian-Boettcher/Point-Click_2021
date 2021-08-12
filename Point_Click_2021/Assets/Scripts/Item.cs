using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item 
{
    public enum ItemType 
    {
        Rattenpuppe,
        farbige_Rattenpuppe,
        Faden,
        Wolle,
        Bürste,
        Bierkrug,
        Bierkruege,
        Wutpilz
    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite(){
        switch(itemType){
            default:
            case ItemType.Rattenpuppe:         return ItemImages.Instance.RattenpuppeSprite;
            case ItemType.farbige_Rattenpuppe: return ItemImages.Instance.farbige_RattenpuppeSprite;
            case ItemType.Faden:               return ItemImages.Instance.FadenSprite;
            case ItemType.Wolle:               return ItemImages.Instance.WolleSprite;
            case ItemType.Bürste:              return ItemImages.Instance.BürsteSprite;
            case ItemType.Bierkrug:            return ItemImages.Instance.BierKrugSprite;
            case ItemType.Bierkruege:          return ItemImages.Instance.BierkruegeSprite;
            case ItemType.Wutpilz:             return ItemImages.Instance.WutpilzSprite;
        }
    }
}
