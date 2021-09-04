using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{  
  public Texture2D cursorTexture;
  public CursorMode cursorMode = CursorMode.Auto;
  public Vector2 hotSpot = Vector2.zero;

  private void Awake() {
    Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
  }
}
