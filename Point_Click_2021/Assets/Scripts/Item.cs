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
        Wutpilz,
        BierKrug_voll,
        BierKrug_mit_Wutpilz,
        BierKruege_voll,
        BierKruege_mit_Wutpilz,
        Schwert_der_Koenige
    }
    public ItemType itemType;
    public int amount;

    public Sprite GetSprite(){
        switch(itemType){
            default:
            case ItemType.Rattenpuppe:            return ItemImages.Instance.Rattenpuppe;
            case ItemType.farbige_Rattenpuppe:    return ItemImages.Instance.farbige_Rattenpuppe;

            case ItemType.Bierkrug:               return ItemImages.Instance.BierKrug;
            case ItemType.BierKrug_voll:          return ItemImages.Instance.BierKrug_voll;
            case ItemType.BierKrug_mit_Wutpilz:   return ItemImages.Instance.BierKrug_mit_Wutpilz;

            case ItemType.Bierkruege:             return ItemImages.Instance.Bierkruege;
            case ItemType.BierKruege_voll:        return ItemImages.Instance.Bierkruege_voll;
            case ItemType.BierKruege_mit_Wutpilz: return ItemImages.Instance.Bierkruege_mit_Wutpilz;

            case ItemType.Wutpilz:                return ItemImages.Instance.Wutpilz;
            case ItemType.Faden:                  return ItemImages.Instance.Faden;
            case ItemType.Wolle:                  return ItemImages.Instance.Wolle;
            case ItemType.Bürste:                 return ItemImages.Instance.Bürste;
            case ItemType.Schwert_der_Koenige:    return ItemImages.Instance.Schwert_der_Koenige;
        }
    }
}
