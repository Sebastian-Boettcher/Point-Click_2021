using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public interface IUnit
{
   Vector2 GetPosition();
   void SetPosition(Vector2 position);

   int GetInv_Amount();
   void Setinv_Amount(int inv_Amount);

   string [] GetItems();
   void SetItems(string [] Items);

   int Get_LastScene();
   void SetlastScene(int last_scene);

}
