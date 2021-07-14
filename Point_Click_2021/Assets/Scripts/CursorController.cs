using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
   public Texture2D cursor;
   public Texture2D cursorClick;

    private void Awake(){
      ChangeCursor(cursor);
      Cursor.lockState = CursorLockMode.Confined;
    }
    
    private void ChangeCursor(Texture2D cursorType){
      Cursor.SetCursor(cursorType,Vector2.zero, CursorMode.Auto);
    }

    void Start()
    {
        
    }
}
