using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemImages : MonoBehaviour
{
    public static ItemImages Instance { 
        get; private set; 
    }

    private void Awake(){
        Instance = this;
    }

    public Sprite FadenSprite;
    public Sprite RattenpuppeSprite;
    public Sprite farbige_RattenpuppeSprite;
    public Sprite BierKrugSprite;
    public Sprite BierkruegeSprite;
    public Sprite BürsteSprite;
    public Sprite WolleSprite;
    public Sprite WutpilzSprite;
    

}
