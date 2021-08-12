using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySteuerung : MonoBehaviour
{
    public Button Inventory;
    public GameObject invent;


    public void show_hide_Inv(){
        if(invent.activeSelf){
            Debug.Log("Ist Aktiv und wird ausgeschaltet!");   
            invent.SetActive(false);
        } else {
            Debug.Log("Ist NOT Aktiv und wird eingeschaltet!");
            invent.SetActive(true);
        }
    }

   /* public void take_Item(){
        if(Input.GetMouseDown(0)){
           items.transform.parent = invent.transform ;
        }
        
    }

*/
}
