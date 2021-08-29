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

    public Sprite Faden;
    public Sprite Rattenpuppe;
    public Sprite farbige_Rattenpuppe;
    public Sprite BierKrug;
    public Sprite BierKrug_voll;
    public Sprite BierKrug_mit_Wutpilz;
    public Sprite Bierkruege;
    public Sprite Bierkruege_voll;
    public Sprite Bierkruege_mit_Wutpilz;
    public Sprite Bürste;
    public Sprite Wolle;
    public Sprite Wutpilz;
    public Sprite Elfenhalskette;
    public Sprite Schwert_der_Koenige;
    

}
