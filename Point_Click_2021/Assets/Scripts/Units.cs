using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.IO;
using UnityEngine;

public class GameInfo: MonoBehaviour {
   
   public Vector2 Get_Position(){
      Vector2 player = GameObject.Find("Player").transform.position;
      return player;
   }
   public void Set_Position(Vector2 position){
      GameObject.Find("Player").transform.position = position;
   }

   private List<Item> itemList;
  /* public int GetInv_Amount(){

   }
   void Setinv_Amount(int inv_Amount);

   List<Item> GetItems();
   void SetItems(string [] Items);

   public int Get_LastScene(){
      int l_scene = SceneManager.GetActiveScene().buildIndex;
      return l_scene;
   }
   public void SetlastScene(int last_scene){
      SceneManager.LoadScene(last_scene);
   }*/
}
