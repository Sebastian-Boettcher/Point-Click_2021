using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour , IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler{

private RectTransform rectTransform;
private CanvasGroup canvasGroup;
[SerializeField] private Canvas canvas;

private void Awake(){
    rectTransform = GetComponent<RectTransform>();
    canvasGroup = GetComponent<CanvasGroup>();
}
public void OnBeginDrag(PointerEventData eventData){
    Debug.Log("Begin Drag");
    canvasGroup.alpha = .6f;
    canvasGroup.blocksRaycasts = false;
  }
public void OnDrag(PointerEventData eventData){
    Debug.Log("OnDrag");
    rectTransform.anchoredPosition += eventData.delta/canvas.scaleFactor;
  }
public void OnEndDrag(PointerEventData eventData){
    Debug.Log("End Drag");
        canvasGroup.alpha = 1f;

    canvasGroup.blocksRaycasts = false;
  }
public void OnPointerDown(PointerEventData eventData){
    Debug.Log("Pointer Down");
  }
public void OnDrop(PointerEventData eventData){
    Debug.Log("On Drop");
  }
}
